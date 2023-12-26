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
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace QuanLiCuaHangGiaySABO.QlSG
{
    public partial class frmSign : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db = new bangiayDataContext();
        public frmSign()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã nhập đủ thông tin chưa
            if (string.IsNullOrWhiteSpace(te_username.Text) || string.IsNullOrWhiteSpace(te_password.Text) ||
                string.IsNullOrWhiteSpace(textEdit1.Text) || string.IsNullOrWhiteSpace(textEdit2.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tạo đối tượng người dùng mới
                DangKy newUser = new DangKy
                {
                    TenDangNhap = te_username.Text,
                    MatKhau = te_password.Text,
                    Email = textEdit2.Text
                };

                // Thêm người dùng mới vào cơ sở dữ liệu
                db.DangKies.InsertOnSubmit(newUser);

                // SubmitChanges để lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form đăng ký sau khi đăng ký thành công
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}