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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QuanLiCuaHangGiaySABO.QlSG
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;
        public frmLogin()
        {
            
            InitializeComponent();
            // Khởi tạo đối tượng của BANGIAYDataContext
            db = new bangiayDataContext();
            // Gắn sự kiện click cho nút đăng nhập
            sb_login.Click += sb_login_Click;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPress += frmLogin_KeyPress;
        }

        private void sb_sign_Click(object sender, EventArgs e)
        {
            frmSign sign = new frmSign();
            sign.ShowDialog();
        }

        private void sb_login_Click(object sender, EventArgs e)
        {
            string username = te_username.Text;
            string password = te_password.Text;

            // Kiểm tra đăng nhập bằng LINQ to SQL
            var user = db.NhanViens.FirstOrDefault(u => u.TenDangNhap == username && u.MatKhau == password);

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Mở form trang chủ hoặc thực hiện các hành động khác
                // Tạo đối tượng form trang chủ
                frmTrangChu homeForm = new frmTrangChu();

                // Hiển thị form trang chủ
                homeForm.Show();

                // Đóng form đăng nhập (nếu cần)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng thử lại.");
            }
        }

        private void sb_login_Enter(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            }

        private void hpl_fogotpass_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            // Mở form quên mật khẩu hoặc thực hiện các hành động mong muốn
            frmForgotPassword forgotPasswordForm = new frmForgotPassword();
            forgotPasswordForm.ShowDialog();
        }
    }
    }
