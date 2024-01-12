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
    public partial class frmbaocao : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;

        public frmbaocao()
        {
            InitializeComponent();
        }

        private void frmbaocao_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();
        }

        private void ThongKeDoanhThu(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            try
            {
                // Lấy danh sách các hóa đơn và chi tiết hóa đơn trong khoảng thời gian đã chọn
                var rs = from hd in db.HoaDons
                         join ct in db.ChiTietHoaDons on hd.MaHoaDon equals ct.MaHoaDon
                         join sp in db.SanPhams on ct.MaSanPham equals sp.MaSanPham
                         where hd.NgayDatHang >= ngayBatDau && hd.NgayDatHang <= ngayKetThuc && hd.danhap == null
                         select new
                         {
                             NgayDatHang = hd.NgayDatHang,
                             sp.TenSanPham,
                             ct.SoLuong,
                             Gia = ct.SanPham.Gia,
                             ThanhTien = (ct.SoLuong * ct.SanPham.Gia)
                         };

                dgvdoanhthu.DataSource = rs.ToList();

                // Tính tổng doanh thu
                decimal tongDoanhThu = rs.Sum(item => item.ThanhTien.GetValueOrDefault());
                lbltongdoanhthu.Text = tongDoanhThu.ToString("N0");

                // Đặt lại HeaderText và chiều rộng cột
                dgvdoanhthu.Columns["NgayDatHang"].HeaderText = "Ngày Đặt Hàng";
                dgvdoanhthu.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
                dgvdoanhthu.Columns["SoLuong"].HeaderText = "Số Lượng";
                dgvdoanhthu.Columns["Gia"].HeaderText = "Giá";
                dgvdoanhthu.Columns["ThanhTien"].HeaderText = "Thành Tiền";
                dgvdoanhthu.Columns["Gia"].DefaultCellStyle.Format = "N0";
                dgvdoanhthu.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

                dgvdoanhthu.Columns["NgayDatHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvdoanhthu.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvdoanhthu.Columns["SoLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvdoanhthu.Columns["Gia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvdoanhthu.Columns["ThanhTien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thống kê doanh thu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThongKeChiPhi(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            try
            {
                // Lấy danh sách các hóa đơn đã nhập trong khoảng thời gian đã chọn
                var hoaDonDaNhap = from hoaDon in db.HoaDons
                                   where hoaDon.danhap == 1 && hoaDon.ngaynhaphang >= ngayBatDau && hoaDon.ngaynhaphang <= ngayKetThuc
                                   select new
                                   {
                                       hoaDon.MaHoaDon,
                                       hoaDon.ngaynhaphang,
                                   };

                // Thêm cột vào dgvchiphi nếu chưa có
                if (dgvchiphi.Columns.Count == 0)
                {
                    dgvchiphi.Columns.Add("MaHoaDon", "Mã Hóa Đơn");
                    dgvchiphi.Columns.Add("ngaynhaphang", "Ngày Nhập"); // Add the column for NgayNhap
                    dgvchiphi.Columns.Add("TenSanPham", "Tên Sản Phẩm");
                    dgvchiphi.Columns.Add("SoLuong", "Số Lượng");
                    dgvchiphi.Columns.Add("Gia", "Giá");
                    dgvchiphi.Columns.Add("ThanhTien", "Thành Tiền");
                }

                // Xóa dữ liệu cũ trong DataGridView
                dgvchiphi.Rows.Clear();

                // Khởi tạo biến để tính tổng chi phí
                decimal tongChiPhi = 0;

                // Thực hiện thống kê chi phí cho từng hóa đơn đã nhập trong khoảng thời gian đã chọn
                foreach (var hoaDon in hoaDonDaNhap)
                {
                    // Lấy chi tiết hóa đơn của hóa đơn đã nhập trong khoảng thời gian đã chọn
                    var chiTietHoaDon = from ct in db.ChiTietHoaDons
                                        join sp in db.SanPhams on ct.MaSanPham equals sp.MaSanPham
                                        where ct.MaHoaDon == hoaDon.MaHoaDon
                                        select new
                                        {
                                            hoaDon.MaHoaDon,
                                            hoaDon.ngaynhaphang,
                                            sp.TenSanPham,
                                            ct.SoLuong,
                                            ct.Gia,
                                            ThanhTien = ct.SoLuong * ct.Gia
                                        };

                    // Hiển thị chi tiết hóa đơn trong DataGridView
                    foreach (var chiTiet in chiTietHoaDon)
                    {
                        dgvchiphi.Rows.Add(chiTiet.MaHoaDon, chiTiet.ngaynhaphang, chiTiet.TenSanPham, chiTiet.SoLuong, chiTiet.Gia, chiTiet.ThanhTien);
                        tongChiPhi += chiTiet.ThanhTien ?? 0;
                    }
                }

                // Hiển thị tổng chi phí trên Label
                lbltongchiphi.Text = tongChiPhi.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thống kê chi phí: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void sb_thongke_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy ngày bắt đầu và kết thúc từ DateTimePicker
                DateTime ngayBatDau = dtp_batdau.Value;
                DateTime ngayKetThuc = dtp_ketthuc.Value;

                // Gọi hàm thống kê doanh thu và truyền tham số ngày bắt đầu và kết thúc
                ThongKeDoanhThu(ngayBatDau, ngayKetThuc);

                // Gọi hàm thống kê chi phí
                dgvchiphi.Rows.Clear(); // Xóa dữ liệu cũ trước khi thống kê mới
                ThongKeChiPhi(ngayBatDau, ngayKetThuc);
                // Lấy tổng doanh thu và tổng chi phí từ DataGridView
                decimal tongDoanhThu = dgvdoanhthu.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToDecimal(row.Cells["ThanhTien"].Value ?? 0));
                decimal tongChiPhi = dgvchiphi.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToDecimal(row.Cells["ThanhTien"].Value ?? 0));

                // Tính lợi nhuận
                decimal loiNhuan = tongDoanhThu - tongChiPhi;

                // Hiển thị lợi nhuận trên Label
                lblloinhuan.Text = loiNhuan.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thống kê doanh thu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}