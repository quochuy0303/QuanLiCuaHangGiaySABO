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
        bangiayDataContext db;
        public frmForgotPassword()
        {
            InitializeComponent();
            db = new bangiayDataContext();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Lấy địa chỉ email từ TextBox
            string emailAddress = textEdit1.Text;

            // Kiểm tra xem địa chỉ email có tồn tại trong cơ sở dữ liệu hay không
            using (var context = new bangiayDataContext())
            {
                var user = context.NhanViens.FirstOrDefault(u => u.Email == emailAddress);

                if (user != null)
                {
                    // Địa chỉ email tồn tại, tạo mật khẩu mới và cập nhật vào cơ sở dữ liệu
                    string newPassword = GenerateRandomPassword(8); // Hàm tạo mật khẩu ngẫu nhiên

                    // Cập nhật mật khẩu mới vào cơ sở dữ liệu
                   // user.MatKhau = HashPassword(newPassword); // Hàm mã hóa mật khẩu trước khi lưu

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SubmitChanges();

                    // Gửi email chứa mật khẩu mới
                    SendPasswordEmail(emailAddress, newPassword);

                    // Hiển thị thông báo hoặc thực hiện các bước khác
                    MessageBox.Show("Mật khẩu mới đã được gửi đến địa chỉ email của bạn. Vui lòng kiểm tra hộp thư đến của bạn.");
                }
                else
                {
                    // Địa chỉ email không tồn tại trong cơ sở dữ liệu
                    MessageBox.Show("Địa chỉ email không tồn tại trong hệ thống. Vui lòng kiểm tra lại.");
                }
            }

            // Đóng form quên mật khẩu
            this.Close();
        }
        private string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder randomPassword = new StringBuilder();

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                randomPassword.Append(chars[index]);
            }

            return randomPassword.ToString();
        }

        // Hàm mã hóa mật khẩu (cần cài đặt logic mã hóa của riêng bạn)
        private string HashPassword(string password)
        {
            // Cài đặt logic mã hóa mật khẩu của bạn
            // Ví dụ đơn giản: Mã hóa mật khẩu bằng MD5
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        // Hàm gửi email chứa mật khẩu mới (cần cài đặt logic gửi email của riêng bạn)
        private void SendPasswordEmail(string emailAddress, string newPassword)
        {
            // Cài đặt logic gửi email của bạn
            // Thay thế các giá trị sau đây bằng thông tin của bạn
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "qhuy071003@gmail.com";
            string smtpPassword = "Vtqh032003@@";
            string senderEmail = "qhuy071003@gmail.com";

            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient(smtpServer);

                mail.From = new System.Net.Mail.MailAddress(senderEmail);
                mail.To.Add(emailAddress);
                mail.Subject = "Mật khẩu mới";
                mail.Body = "Mật khẩu mới của bạn là: " + newPassword;

                SmtpServer.Port = smtpPort;
                SmtpServer.Credentials = new System.Net.NetworkCredential(smtpUsername, smtpPassword);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                XtraMessageBox.Show("Email đã được gửi chứa mật khẩu mới.");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi khi gửi email: " + ex.Message);
            }
        }

    }
}