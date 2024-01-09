using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public frmNhapHang()
        {
            InitializeComponent();
            db = new bangiayDataContext();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();
            showdata();
        }
        private void showdata()
        {
            var query = from hoaDon in db.HoaDons
                        join nhaCungCap in db.NhaCungCaps on hoaDon.MaNhaCungCap equals nhaCungCap.MaNhaCungCap
                        join nhanVien in db.NhanViens on hoaDon.MaNhanVien equals nhanVien.MaNhanVien
                        select new
                        {
                         id = hoaDon.MaHoaDon,
                         NgayNhap = hoaDon.NgayDatHang,
                         TenNCC = nhaCungCap.TenNhaCungCap,
                         TenNhanVien = nhanVien.TenNhanVien,
                         danhap = hoaDon.danhap,
                         trangthai = hoaDon.danhap == 1 ? "Đã nhập" : "Yêu cầu",
                         tongtien = db.ChiTietHoaDons.Where(x => x.MaHoaDon == hoaDon.MaHoaDon).Sum(y => y.SoLuong * y.Gia),
                     };

            dgvNhapHang.DataSource = query.ToList();
        }
    }
}