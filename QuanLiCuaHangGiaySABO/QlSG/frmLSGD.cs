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
    public partial class frmLSGD : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;
        public double TongTienDonDatHang { get; set; }
        public frmLSGD()
        {
            InitializeComponent();
        }
        public void CapNhatDgvLSGD()
        {
            // Gọi hàm LayDuLieuChoDgvLSGD để lấy dữ liệu từ cơ sở dữ liệu
            DataTable dataTable = LayDuLieuChoDgvLSGD();

            // Gán dữ liệu cho dgvLSGD
            dgvLSGD.DataSource = dataTable;

            // Lấy giá trị của TongTienDonDatHang và thực hiện các xử lý khác nếu cần
            double tongTienDonDatHang = this.TongTienDonDatHang;
        }
        private DataTable LayDuLieuChoDgvLSGD()
        {
            DataTable dataTable = new DataTable();

            // Kiểm tra xem biến db đã được khởi tạo chưa
            if (db == null)
            {
                // Thông báo lỗi hoặc thực hiện các bước xử lý khác tùy thuộc vào yêu cầu của bạn
                MessageBox.Show("Biến db chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dataTable;
            }

            // Tạo cột cho DataTable
            dataTable.Columns.Add("NgayDatHang", typeof(DateTime));
            dataTable.Columns.Add("TenSanPham", typeof(string));
            dataTable.Columns.Add("SoLuong", typeof(int));
            dataTable.Columns.Add("Gia", typeof(decimal));
            dataTable.Columns.Add("ThanhTien", typeof(decimal));

            // Truy vấn kết hợp dữ liệu từ các bảng
            var query = from hoaDon in db.HoaDons
                        join chiTiet in db.ChiTietHoaDons on hoaDon.MaHoaDon equals chiTiet.MaHoaDon
                        join sanPham in db.SanPhams on chiTiet.MaSanPham equals sanPham.MaSanPham
                        select new
                        {
                            hoaDon.NgayDatHang,
                            sanPham.TenSanPham,
                            chiTiet.SoLuong,
                            sanPham.Gia,
                            ThanhTien = chiTiet.SoLuong * sanPham.Gia
                        };

            // Thêm dữ liệu từ truy vấn vào DataTable
            foreach (var item in query)
            {
                dataTable.Rows.Add(item.NgayDatHang, item.TenSanPham, item.SoLuong, item.Gia, item.ThanhTien);
            }

            return dataTable;
        }
    }
}