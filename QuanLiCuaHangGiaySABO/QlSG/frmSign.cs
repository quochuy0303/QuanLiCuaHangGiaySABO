using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace QuanLiCuaHangGiaySABO.QlSG
{
    public partial class frmSign : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;
        public frmSign()
        {
            InitializeComponent();
            db = new bangiayDataContext();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các controls trên form
            string username = te_username.Text;
            string password = te_password.Text;
            string confirmPassword = textEdit1.Text;
            string email = textEdit2.Text;
            string role = comboBoxEdit1.Text;

            // Kiểm tra các thông tin có hợp lệ không
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new bangiayDataContext())
            {
                // Kiểm tra xem username đã tồn tại hay chưa
                var existingUser = context.NhanViens.FirstOrDefault(u => u.TenDangNhap == username);

                if (existingUser != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Kiểm tra xem email đã tồn tại hay chưa
                var existingEmail = context.NhanViens.FirstOrDefault(u => u.Email == email);

                if (existingEmail != null)
                {
                    MessageBox.Show("Email đã tồn tại. Vui lòng sử dụng một email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo mới đối tượng Nhân viên
                NhanVien newUser = new NhanVien
                {
                    TenNhanVien = "Chương",
                    DiaChi = "Bình Thạnh",
                    SoDienThoai = "0388255376",
                    Email = email,
                    VaiTro = role,
                    TenDangNhap = username,
                    MatKhau = HashFunction(password)//mã hóa trong csdl khi nhập mật khẩu đăng kí.
                };

                // Thêm mới Nhân viên vào cơ sở dữ liệu
                context.NhanViens.InsertOnSubmit(newUser);
                context.SubmitChanges();

                MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSign_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.Properties.Items.AddRange(new object[] {
        "Nhân Viên",
        "Admin"});
            // Ẩn mật khẩu và xác nhận mật khẩu ban đầu
            te_password.Properties.UseSystemPasswordChar = true;
            textEdit1.Properties.UseSystemPasswordChar = true;
        }

        private string HashFunction(string input)
        {
            // Thực hiện hàm hash (ví dụ: MD5, SHA-256, SHA-512)
            // Trong thực tế, bạn nên sử dụng thư viện bảo mật như BCrypt hoặc PBKDF2
            // Đây chỉ là một ví dụ đơn giản để minh họa ý tưởng
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }
    }

    }
