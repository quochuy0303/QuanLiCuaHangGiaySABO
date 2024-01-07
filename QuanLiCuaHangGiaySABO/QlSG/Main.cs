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

namespace QuanLiCuaHangGiaySABO.QlSG
{
   // private frmLogin loginForm;
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        private Form activeForm = null;
        private frmLogin loginForm;
        public Main(frmLogin loginForm)
        {
            InitializeComponent();           
            loginForm = new frmLogin();
            this.loginForm = loginForm;
            hideSubMenu();
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
    }
    }
