using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangGiaySABO.QlSG
{
    public partial class frmChiTietNhap : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;
        private DataGridViewRow r;
        private int maHD;
        private byte danhap;
        public frmChiTietNhap(int maHD, byte danhap)
        {
            InitializeComponent();
            this.danhap = danhap;
            this.maHD = maHD; // tham số này đc truyền qua để lấy maHD
        }

        private void frmChiTietNhap_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();

            rbtyeucau.CheckedChanged += rbtyeucau_CheckedChanged;
            txttienthanhtoan.Enabled = !rbtyeucau.Checked;
            //truy vấn vào hóa đơn chỉ lấy những hóa đơn có trạng thái đã nhập là 1
            var hd = db.HoaDons.SingleOrDefault(x => x.MaHoaDon == maHD);
            if (hd.danhap == 1)
            {
                btnThem.Enabled = btnxoa.Enabled = false;
            }

            var rs = from h in db.SanPhams
                     select new
                     {
                         tenmathang = h.TenSanPham,
                         mahang = h.MaSanPham
                     };

            cbbmathang.DataSource = rs;

            cbbmathang.DisplayMember = "tenmathang";
            cbbmathang.ValueMember = "mahang";
            cbbmathang.SelectedIndex = -1;
            showdata();

        }

        private void showdata()
        {
            var rs = (from c in db.ChiTietHoaDons
                      join h in db.SanPhams on c.MaSanPham equals h.MaSanPham
                      join hd in db.HoaDons on c.MaHoaDon equals hd.MaHoaDon
                      where c.MaHoaDon == maHD
                      select new
                      {
                          idmathang = h.MaSanPham,
                          mathang = h.TenSanPham,
                          sl = c.SoLuong,
                          dg = c.Gia,
                          thanhtien = c.SoLuong * c.Gia,
                          hd.ngaynhaphang // Assuming "NgayNhap" is the column in HoaDon table representing the entry date
                      }) ;

            dgvchitiethoadon.DataSource = rs.ToList();
            lbltongtien.Text = string.Format("Tổng Tiền:{0:N0}", rs.Sum(x => x.thanhtien));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbbmathang.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra đơn giá
            if (!uint.TryParse(txtdongia.Text, out uint donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ. Vui lòng nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số lượng
            if (!uint.TryParse(txtSL.Text, out uint soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ct = new ChiTietHoaDon();
            ct.MaHoaDon = maHD;

            var item = db.ChiTietHoaDons.FirstOrDefault(x => x.MaHoaDon == maHD && x.MaSanPham == int.Parse(cbbmathang.SelectedValue.ToString()));

            if (item == null)
            {
                ct.MaSanPham = int.Parse(cbbmathang.SelectedValue.ToString());
                ct.Gia = int.Parse(txtdongia.Text);
                ct.SoLuong = int.Parse(txtSL.Text);
                db.ChiTietHoaDons.InsertOnSubmit(ct);

                // Cập nhật ngày nhập hàng ngay tại đây
                var hd = db.HoaDons.SingleOrDefault(x => x.MaHoaDon == maHD);
                hd.ngaynhaphang = DateTime.Now;
                db.SubmitChanges();
            }
            else
            {
                item.SoLuong += int.Parse(txtSL.Text);
                db.SubmitChanges();
            }

            showdata();
        }

        private void dgvchitiethoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvchitiethoadon.Rows[e.RowIndex];
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui Lòng chọn mặt hàng cần xóa ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa mặt hàng" + r.Cells["mathang"].Value.ToString() + "?", "Xác nhận xóa ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                )
            {
                var item = db.ChiTietHoaDons.FirstOrDefault(x => x.MaHoaDon == maHD && x.MaSanPham == int.Parse(r.Cells["idmathang"].Value.ToString()));
                db.ChiTietHoaDons.DeleteOnSubmit(item);
                db.SubmitChanges();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                showdata();
            }
        }
    
    
        public event EventHandler NhapHangThanhCong;

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if (dgvchitiethoadon.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập mặt hàng hóa đơn nhập trước khi tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra nếu người dùng đã nhập tiền thanh toán
            int tienThanhToan = 0;           

            // Lưu thông tin đã nhập vào cơ sở dữ liệu
            var hd = db.HoaDons.SingleOrDefault(x => x.MaHoaDon == maHD);

            // Cập nhật số lượng sản phẩm trong bảng SanPhams
            foreach (DataGridViewRow row in dgvchitiethoadon.Rows)
            {
                int maSanPham = Convert.ToInt32(row.Cells["idmathang"].Value);
                int soLuongNhap = Convert.ToInt32(row.Cells["sl"].Value);

                // Lấy thông tin sản phẩm từ bảng SanPhams
                var sanPham = db.SanPhams.SingleOrDefault(sp => sp.MaSanPham == maSanPham);

                if (sanPham != null)
                {
                    // Cập nhật số lượng sản phẩm
                    sanPham.SoLuong += soLuongNhap;
                }
            }

            // Cập nhật thông tin hóa đơn
            hd.tienthanhtoan = int.Parse(txttienthanhtoan.Text);
            hd.danhap = rbtyeucau.Checked ? (byte)0 : (byte)1;

            // Thêm hoặc cập nhật ngày nhập vào hóa đơn
            hd.ngaynhaphang = DateTime.Now;

            // Lưu thay đổi vào cơ sở dữ liệu
            db.SubmitChanges();
            NhapHangThanhCong?.Invoke(this, EventArgs.Empty);

            // Đóng form khi hoàn thành
            this.Dispose();
        }


        private void rbtyeucau_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtyeucau.Checked)
            {
                txttienthanhtoan.Enabled = false;//Nếu yêu ở chế độ yêu cầu thì chưa thanh toán                

            }
            else
            {
                txttienthanhtoan.Enabled = true;//ngược lại thì cần nhập số tiền đã thanh toán cho nhà cung cấp
            }
        }

        private void txttienthanhtoan_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttienthanhtoan.Text))
            {
                if (!int.TryParse(txttienthanhtoan.Text, out _))
                {
                    MessageBox.Show("Vui lòng nhập số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttienthanhtoan.Text = ""; // Bạn có thể thay thế bằng giá trị mặc định khác nếu muốn
                }
            }
        }
    }
}