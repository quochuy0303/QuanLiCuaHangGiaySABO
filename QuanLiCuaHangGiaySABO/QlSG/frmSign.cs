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

                // Tạo mới đối tượng Nhân viên
                NhanVien newUser = new NhanVien
                {
                    TenNhanVien = "Chương",
                    DiaChi = "Bình Thạnh",
                    SoDienThoai = "0388255376",
                    Email = email,
                    VaiTro = role,
                    TenDangNhap = username,
                    MatKhau = password
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
        }

        private string HashPassword(string password)
        {
            // Sử dụng thuật toán băm SHA-256
            using (SHA256 sha256 = SHA256.Create())
            {
                // Mã hóa mật khẩu thành mảng byte
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Chuyển đổi mảng byte thành chuỗi hex
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }

    }
