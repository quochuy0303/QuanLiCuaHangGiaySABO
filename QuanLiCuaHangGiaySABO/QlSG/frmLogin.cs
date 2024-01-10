using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using BCrypt.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using DevExpress.XtraWaitForm;

namespace QuanLiCuaHangGiaySABO.QlSG
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;      

        public frmLogin(frmLogin mainForm)
        {
            
            InitializeComponent();
            // Khởi tạo đối tượng của BANGIAYDataContext
            db = new bangiayDataContext();
            // Gắn sự kiện click cho nút đăng nhập
            sb_login.Click += sb_login_Click;
            ce_ShowPassword.CheckedChanged += ce_ShowPassword_CheckedChanged;
            te_password.Properties.UseSystemPasswordChar = true;
            te_username.TabIndex = 1;
            te_password.TabIndex = 2;
            ce_ShowPassword.TabIndex = 3;
            sb_login.TabIndex = 4;
            sb_sign.TabIndex = 5;
            hpl_fogotpass.TabIndex = 6;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void sb_sign_Click(object sender, EventArgs e)
        {
            frmSign sign = new frmSign();
            sign.ShowDialog();
        }

        private void sb_login_Click(object sender, EventArgs e)
        {
            // Sử dụng using để đảm bảo giải phóng tài nguyên
            using (var db = new bangiayDataContext())
            {
                string username = te_username.Text;
                string password = te_password.Text;

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra đăng nhập bằng LINQ to SQL
                var user = db.NhanViens.FirstOrDefault(u => u.TenDangNhap == username);

                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.MatKhau))
                {
                    // Lấy thông tin nhân viên và quyền từ csdl
                    string tenNhanVien = user.TenNhanVien;
                    string quyen = user.VaiTro;
                    Image userImage = Properties.Resources.profile;
                    // Tạo một thể hiện của MainForm
                    Main homeForm = new Main(this);            
                    // Gọi phương thức SetThongTinNhanVien từ thể hiện của MainForm để cập nhật thông tin nhân viên và quyền
                    homeForm.SetThongTinNhanVien(tenNhanVien, quyen ,userImage);
                    MessageBox.Show("Đăng nhập thành công!");                    
                    homeForm.Show();
                   
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng thử lại.");
                }
                
            }       
    }
      

        private void hpl_fogotpass_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            // Mở form quên mật khẩu hoặc thực hiện các hành động mong muốn
            frmForgotPassword forgotPasswordForm = new frmForgotPassword();
            forgotPasswordForm.ShowDialog();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sb_login_Click(sender, e);
            }
        }
        // Thêm phương thức để hiển thị form đăng nhập khi cần quay lại
        public void ShowLoginForm()
        {
            this.Show();
            this.te_username.Text = string.Empty;
            this.te_password.Text = string.Empty;
        }

        private void ce_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu người dùng chọn hiển thị mật khẩu
            if (ce_ShowPassword.Checked)
            {
                te_password.Properties.UseSystemPasswordChar = false; // Hiển thị mật khẩu
            }
            else
            {
                te_password.Properties.UseSystemPasswordChar = true; // Ẩn mật khẩu
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
