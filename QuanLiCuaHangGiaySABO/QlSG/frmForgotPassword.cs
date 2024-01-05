using DevExpress.XtraBars.Docking2010.Views.Widget;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QuanLiCuaHangGiaySABO.QlSG
{
    public partial class frmForgotPassword : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;
        private Random random = new Random();      
        private string verification_code;
        private string userEmail;
        public frmForgotPassword()
        {
            InitializeComponent();
            db = new bangiayDataContext();
            verification_code = MaXacNhan();
        }
        //random Mã xác nhận
        private string MaXacNhan()
        {
            Random random = new Random();
            int code = random.Next(000000, 999999);
            return code.ToString();
        }

        //ẩn mật khẩu
        private async void HidePassword(TextBox textBox)
        {
            textBox.UseSystemPasswordChar = false;
            await Task.Delay(3000);
            textBox.UseSystemPasswordChar = true;
        }


        private void sp_OTP_Click(object sender, EventArgs e)
        {
            userEmail = txtemail.Text;

            // Kiểm tra xem email có tồn tại trong cơ sở dữ liệu hay không
            var user = db.NhanViens.FirstOrDefault(u => u.Email == userEmail);

            if (user != null)
            {
                // Gửi OTP đến email của người dùng
                SendEmail(userEmail, verification_code);
                MessageBox.Show("Đã gửi OTP đến địa chỉ email của bạn.");
            }
            else
            {
                MessageBox.Show("Email không nằm trong hệ thống. Vui lòng kiểm tra lại!");
            }
        }

        private void sb_xacnhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra OTP nhập vào với mã xác nhận đã gửi
            if (txtOTP.Text == verification_code)
            {
                // Xác nhận thành công

                // Kiểm tra mật khẩu mới và xác nhận mật khẩu mới
                if (txtnewpass.Text == txtcomfirm.Text)
                {
                    // Mật khẩu và xác nhận mật khẩu trùng nhau

                    // Lấy thông tin người dùng từ cơ sở dữ liệu
                    var user = db.NhanViens.FirstOrDefault(u => u.Email == userEmail);

                    if (user != null)
                    {
                        // Hash mật khẩu mới trước khi lưu vào cơ sở dữ liệu
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtnewpass.Text);

                        // Cập nhật mật khẩu mới trong cơ sở dữ liệu
                        user.MatKhau = hashedPassword;

                        // Lưu thay đổi vào cơ sở dữ liệu
                        db.SubmitChanges();

                        MessageBox.Show("Đặt lại mật khẩu thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không thể tìm thấy người dùng trong cơ sở dữ liệu.");
                    }
                }
                else
                {
                    // Mật khẩu và xác nhận mật khẩu không trùng nhau
                    MessageBox.Show("Mật khẩu và xác nhận mật khẩu không trùng nhau. Vui lòng kiểm tra lại!");
                }
            }
            else
            {
                // Xác nhận thất bại
                MessageBox.Show("Mã xác nhận không đúng. Vui lòng thử lại!");
            }
        }

        // Hàm gửi email
        private void SendEmail(string toEmail, string otpCode)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                // Thay thế "your_email_password_here" bằng mật khẩu ứng dụng bạn đã tạo
                smtpClient.Credentials = new NetworkCredential("qhuy071003@gmail.com", "lugtxuvzlvsvohdl");
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("qhuy071003@gmail.com");
                mailMessage.To.Add(toEmail);
                mailMessage.Subject = "Mã xác nhận OTP";
                mailMessage.Body = $"Mã xác nhận của bạn là: {otpCode}";

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gửi email thất bại: {ex.Message}");
            }
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