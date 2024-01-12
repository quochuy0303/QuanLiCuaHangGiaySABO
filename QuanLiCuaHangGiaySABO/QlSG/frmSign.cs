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
        //hàm kiểm sdt trùng lặp
        private bool KiemTraSDTTrungLap(string SDT)
        {
            var existingUser = db.NhanViens.FirstOrDefault(u => u.SoDienThoai == SDT);

            return existingUser != null;
        }
        //sự kiện sdt keypress chỉ nhập số     
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các controls trên form
            string username = te_username.Text;
            string password = te_password.Text;
            string confirmPassword = textEdit1.Text;
            string email = textEdit2.Text;
            string quyen = comboBoxEdit1.Text;         
            string hoten = te_hoten.Text;
            string sdt = te_sdt.Text;
            string diachi = te_diachi.Text;

            // Kiểm tra các thông tin có hợp lệ không
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(quyen)||
                string.IsNullOrWhiteSpace(hoten) || string.IsNullOrWhiteSpace(sdt) ||  string.IsNullOrWhiteSpace(diachi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // kiểm tra sự trùng khớp khi nhập mật khẩu và xác nhận mật khẩu
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //kiểm tra số điện thoại có tồn tại trong csdl không
            string SDT = te_sdt.Text;
            if (KiemTraSDTTrungLap(SDT))
            {
                MessageBox.Show("Số điện thoại đã tồn tại trong danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    TenNhanVien = hoten,
                    DiaChi = diachi,
                    SoDienThoai = sdt,
                    Email = email,
                    VaiTro = quyen,
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
        // đổ dữ liệu quyền nhân viên và admin lên sự kiện load form 
        private void frmSign_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.Properties.Items.AddRange(new object[] {
        "Nhân Viên",
        "Admin"});
            // Ẩn mật khẩu và xác nhận mật khẩu ban đầu
            te_password.Properties.UseSystemPasswordChar = true;
            textEdit1.Properties.UseSystemPasswordChar = true;
        }

        // mã hóa và giải mã mật khẩu khi ấn nút đăng kí để có thể đăng nhập thành công
        private string HashFunction(string input)
        {          
                return BCrypt.Net.BCrypt.HashPassword(input);
            }

        private void te_sdt_TextChanged(object sender, EventArgs e)
        {
            string sdt = te_sdt.Text;
            if (!sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                te_sdt.Text = string.Empty; // Xóa nội dung nhập
                return;
            }

            // Đảm bảo độ dài chính xác là 10 số
            if (sdt.Length > 10)
            {
                MessageBox.Show("Số điện thoại chỉ được nhập 10 số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                te_sdt.Text = sdt.Substring(0, 10); // Cắt bớt nếu vượt quá 10 số
                te_sdt.SelectionStart = te_sdt.Text.Length; // Đặt con trỏ cuối chuỗi
            }
        }

        private void te_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (te_password.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Mật Khẩu chỉ được nhập 8 kí tự ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                // Ngăn chặn việc thêm ký tự mới vào ô password
                e.Handled = true;
            }
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textEdit1.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Xác Nhận Mật Khẩu chỉ được nhập 8 kí tự ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Ngăn chặn việc thêm ký tự mới vào ô xác nhận mật khẩu
                e.Handled = true;
            }
        }
    }
    }

    
