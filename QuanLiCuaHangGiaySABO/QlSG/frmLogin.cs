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
        private bangiayDataContext db = new bangiayDataContext();
        public frmLogin()
        {
            //sb_login.Click += sb_login_Click;
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void sb_sign_Click(object sender, EventArgs e)
        {
            frmSign sign = new frmSign();
            sign.ShowDialog();
        }

        private void sb_login_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã nhập đủ thông tin chưa
            if (string.IsNullOrWhiteSpace(te_username.Text) || string.IsNullOrWhiteSpace(te_password.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin đăng nhập
            var user = db.DangKies.FirstOrDefault(u => u.TenDangNhap == te_username.Text && u.MatKhau == te_password.Text);

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển sang form trang chủ sau khi đăng nhập thành công
                frmTrangChu homeForm = new frmTrangChu();
                homeForm.Show();

                // Đóng form đăng nhập
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}