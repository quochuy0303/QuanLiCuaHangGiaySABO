using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHangGiaySABO.QlSG
{
   
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        private Form activeForm = null;
        private frmLogin loginForm;
        private string tenNhanVien;
        private string quyen;
        public Main(frmLogin loginForm)
        {
            InitializeComponent();                      
            this.loginForm = loginForm;
            hideSubMenu();
        }
        public void SetThongTinNhanVien(string tenNhanVien, string quyen, Image userImage)
        {
            this.tenNhanVien = tenNhanVien;
            this.quyen = quyen;
            pictureBoxUser.Image = userImage; // pictureBoxUser là PictureBox để hiển thị hình ảnh
            UpdateThongTinNhanVienLabel();
            PhanQuyen();


        }

         private void PhanQuyen ( ) 
        {
            if (quyen == "Admin")
            {
                btnnhanvien.Enabled = true;
                btnkh.Enabled = true;
                btnNCC.Enabled = true;
                Kho.Enabled = true;
                BtnSP.Enabled = true;
                btnDonHang.Enabled = true;
            }
            else if (quyen == "Nhân Viên")
            {
                btnnhanvien.Enabled = false;
                btnkh.Enabled = true;
                btnNCC.Enabled = false;
                Kho.Enabled = true;
                BtnSP.Enabled = true;
                btnDonHang.Enabled = true;
            }
        }
        private void UpdateThongTinNhanVienLabel()
        {
            // Cập nhật các điều khiển trên MainForm với thông tin nhân viên
            label1.Text = $"Tên nhân viên: {tenNhanVien}";
            label2.Text = $"Quyền: {quyen}";
            

        }
        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmTTLL nhanVienForm = new frmTTLL();

            openChildForm(new frmTTLL());
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Đóng form chính
            this.Close();

            // Hiển thị form đăng nhập
            loginForm.Show();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của form Nhân Viên
            frmNhanVien nhanVienForm = new frmNhanVien();

            openChildForm(new frmNhanVien());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnkh_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của form Nhân Viên
            frmKhachHang nhanVienForm = new frmKhachHang();

            openChildForm(new frmKhachHang());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của form Nhân Viên
            frmNhaCungCap nhanVienForm = new frmNhaCungCap();

            openChildForm(new frmNhaCungCap());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void Kho_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của form Nhân Viên
            frmKho nhanVienForm = new frmKho();

            openChildForm(new frmKho());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void BtnSP_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của form Nhân Viên
            frmQliGiay nhanVienForm = new frmQliGiay();

            openChildForm(new frmQliGiay());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của form Nhân Viên
            frmDonDatHang nhanVienForm = new frmDonDatHang();

            openChildForm(new frmDonDatHang());
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private CultureInfo currentCulture;

        private void UpdateControlLanguage(Control control)
        {
            if (control is Button)
            {
                var button = (Button)control;
                button.Text = LanguageManager.GetString(button.Name + ".Text");
            }

            foreach (Control childControl in control.Controls)
            {
                UpdateControlLanguage(childControl);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Hiển thị form chọn ngôn ngữ
            LanguageSelectionForm languageForm = new LanguageSelectionForm();
            if (languageForm.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật lại ngôn ngữ trong MainForm với ngôn ngữ mới
                UpdateLanguage();
            }
        }
        private void UpdateLanguage()
        {
            // Cập nhật lại các điều khiển trên MainForm với ngôn ngữ mới
            UpdateThongTinNhanVienLabel();
            //... cập nhật các điều khiển khác nếu cần
            ApplyLanguage();
        }
        private void ApplyLanguage()
        {
            btnMedia.Text = LanguageManager.GetString("Media");
            btnPlaylist.Text = LanguageManager.GetString("Playlist");
            btnTools.Text = LanguageManager.GetString("Tools");
            btnHelp.Text = LanguageManager.GetString("Help");
            btnnhanvien.Text = LanguageManager.GetString("NhanVien");
            btnkh.Text = LanguageManager.GetString("KhachHang");
            btnNCC.Text = LanguageManager.GetString("NhaCungCap");
            Kho.Text = LanguageManager.GetString("Kho");
            BtnSP.Text = LanguageManager.GetString("QuanLiGiay");
            btnDonHang.Text = LanguageManager.GetString("DonDatHang");
            btnout.Text = LanguageManager.GetString("Exit");
        }

    }
    }
