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
    public partial class frmKho : DevExpress.XtraEditors.XtraForm
    {
        private frmLogin loginForm;
        private bangiayDataContext db;
      // private DataGridViewRow r;
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();
            showdata();
        }
        
        private void showdata()
        {
            var rs = from kho in db.Khos
                     join matHang in db.SanPhams on kho.MaSanPham equals matHang.MaSanPham
                     select new
                     {
                         matHang.TenSanPham,
                         kho.NgayNhap,
                         matHang.SoLuong,
                         kho.TrangThai                       
                     };

            dgvKho.DataSource = rs.ToList();
        }

        private void sbnhaphang_Click(object sender, EventArgs e)
        {
            // Mở form nhập hàng
            frmNhapHang formNhapHang = new frmNhapHang();

            // Đăng ký sự kiện để nhận thông tin sau khi nhập hàng
            formNhapHang.NhapHangThanhCong += (s, args) => {
                // Cập nhật DataGridView sau khi nhập hàng thành công
                showdata();
            };

            formNhapHang.ShowDialog();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của Main và hiển thị nó
            Main mainForm = new Main(loginForm);
            mainForm.Show();

            // Đóng form hiện tại
            this.Close();
        }
    }
}