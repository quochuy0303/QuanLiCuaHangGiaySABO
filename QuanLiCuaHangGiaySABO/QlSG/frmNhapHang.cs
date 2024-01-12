using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangGiaySABO.QlSG
{
    public partial class frmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;
        private DataGridViewRow r;
        public event EventHandler NhapHangThanhCong;

        public frmNhapHang()
        {
            InitializeComponent();
            db = new bangiayDataContext();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();
            cbbNhanVienNhap.DataSource = db.NhanViens;
            mtbNgayNhap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbbNhanVienNhap.DisplayMember = "TenNhanVien";
            cbbNhanVienNhap.ValueMember = "TenDangNhap";
            cbbNhanVienNhap.SelectedIndex = -1;

            cbbNhaCungcap.DataSource = db.NhaCungCaps;
            cbbNhaCungcap.DisplayMember = "TenNhaCungCap";
            cbbNhaCungcap.ValueMember = "MaNhaCungCap";
            cbbNhaCungcap.SelectedIndex = -1;
            showdata();
            dgvNhapHang.Columns["danhap"].Visible = false;
            dgvNhapHang.Columns["id"].HeaderText = "Mã Hóa Đơn";
            dgvNhapHang.Columns["nhanviennhap"].HeaderText = "Nhân Viên Nhập";
            dgvNhapHang.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            dgvNhapHang.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
            dgvNhapHang.Columns["trangthai"].HeaderText = "Trạng thái";
            dgvNhapHang.Columns["tongtien"].HeaderText = "Tổng tiền";
            dgvNhapHang.Columns["dathanhtoan"].HeaderText = "Đã thanh toán";
            dgvNhapHang.Columns["TenNCC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhapHang.Columns["tongtien"].DefaultCellStyle.Format = "N0";
            dgvNhapHang.Columns["dathanhtoan"].DefaultCellStyle.Format = "N0";
        
    }
        private void showdata()
        {
            var query = from hoaDon in db.HoaDons
                        join nhaCungCap in db.NhaCungCaps on hoaDon.MaNhaCungCap equals nhaCungCap.MaNhaCungCap
                        join nhanVien in db.NhanViens on hoaDon.nhanviennhap equals nhanVien.TenDangNhap
                        select new
                        {
                            id = hoaDon.MaHoaDon,
                            nhanviennhap = nhanVien.TenNhanVien,
                            NgayNhap = hoaDon.NgayDatHang,
                            TenNCC = nhaCungCap.TenNhaCungCap,
                            danhap = hoaDon.danhap,
                            trangthai = hoaDon.danhap == 1 ? "Đã nhập" : "Yêu cầu",
                            tongtien = db.ChiTietHoaDons.Where(x => x.MaHoaDon == hoaDon.MaHoaDon).Sum(y => y.SoLuong * y.Gia),
                            dathanhtoan = hoaDon.tienthanhtoan
                        };

            dgvNhapHang.DataSource = query.ToList();
        }

        private void sbthem_Click(object sender, EventArgs e)
        {
            DateTime ngaynhap;
            try
            {
                ngaynhap = DateTime.ParseExact(mtbNgayNhap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Ngày nhập không hợp lệ", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //nhân viên nhập hàng được hiểu là người phụ trách kiểm kê hàng hóa khi nhập vào kho
            if (cbbNhanVienNhap.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên nhập hàng", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbbNhaCungcap.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var od = new HoaDon();
                od.nhanviennhap = cbbNhanVienNhap.SelectedValue.ToString();
                od.MaNhaCungCap = int.Parse(cbbNhaCungcap.SelectedValue.ToString());
                od.NgayDatHang = ngaynhap;              
                db.HoaDons.InsertOnSubmit(od);
                db.SubmitChanges();


                //MessageBox.Show("Tạo mới hóa đơn nhập thành công "+idHDNhap, "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //theo thiết kế csdl thì hóa đơn nhập và chi tiết hóa đơn nhập có mối quan hệ 1-n
                //trong đó, chi tiết hóa đơn nhập có khóa ngoại là idhoadon trỏ tới khóa chính id của bảng hóa đơn nhập
                //sau khi tạo xong hóa đơn, chúng ta cần nhập mặt hàng vào hóa đơn này đúng không
                //như mẫu hóa đơn mua hàng này, chúng ta phần phía trên chính là thông tin được lưu ở bảng hoadonnhap
                //còn phần phía dưới chính là phần chi tiết của hóa đơn nhập hàng, được lưu ở bảng chitiethoadonnhap
                //=>sau khi tạo xong hóa đơn nhập, cần cho người dùng nhập các mặt hàng tương ứng với hóa đơn vừa tạo
                //cần tạo thêm 1 form chi tiết hóa đơn nhập và truyền id của hóa đơn nhập qua để hệ thống hiểu rằng bạn đang nhập hàng cho hóa đơn nào
                var idHDNhap = db.HoaDons.Max(x => x.MaHoaDon);
                //với hóa đơn nhập mới, trạng thái nhập kho sẽ là false = đang yêu cầu nhập hàng
                new frmChiTietNhap(idHDNhap, 0).ShowDialog();//truyền mã hóa đơn qua
                showdata();//gọi lại hàm hiển thị sau khi phiếu nhập đc thêm.xóa mặt hàng
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Tạo hóa đơn nhập hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhapHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvNhapHang.Rows[e.RowIndex];

                //khi double click vào hàng của datagridview -> lấy được hóa đơn nhập tương ứng
                //từ đó truyền qua 2 giá trị: mã đơn nhập và trạng thái đơn nhập
                //vì r.Cells["id"].Value.ToString() trả về string. trong khi mã đơn nhập là bigint,long nên cần convert qua kiểu long
                //tương tự cho giá trị r.Cells["danhap"].Value.ToString() cần convert qua byte tức là 0 hoặc 1
                //mình sẽ khai báo ngoài cho dễ nhìn

                byte danhapkho = r.Cells["danhap"].Value == null ? (byte)0 : byte.Parse(r.Cells["danhap"].Value.ToString());
                //nguyên cái đoạn lệnh trên có nghĩa là
                //nếu cột danhap của hàng được chọn r là null thì cho giá trị là 0
                //ngược lại nếu khác null -> thì lấy giá trị 0 hoặc 1 rồi convert qua kiểu byte
                //hơi khó hiểu chút nhưng đây chỉ là phép tính 3 ngôi - dạng rút gọn của if..else

                new frmChiTietNhap(int.Parse(r.Cells["id"].Value.ToString()), danhapkho).ShowDialog();//truyền  2 tham số vào frmChiTietHoaDonNhap rồi show lên
                showdata();//gọi lại hàm hiển thị sau khi phiếu nhập đc thêm.xóa mặt hàng
            }
        }
    }
}