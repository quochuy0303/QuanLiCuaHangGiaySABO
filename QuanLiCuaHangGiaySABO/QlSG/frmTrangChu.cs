using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiCuaHangGiaySABO.QlSG
{
    public partial class frmTrangChu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmTrangChu()
        {
            InitializeComponent();
            adc_NCC.Click += adc_NCC_Click;
            adc_nhanvien.Click += adc_nhanvien_Click;
        }

        private void adc_NCC_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị form Nhà Cung Cấp bên trong FluentDesignFormContainer
            frmNhaCungCap nhaCungCapForm = new frmNhaCungCap();
            nhaCungCapForm.TopLevel = false;
            nhaCungCapForm.FormBorderStyle = FormBorderStyle.None;
            nhaCungCapForm.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(nhaCungCapForm);
            nhaCungCapForm.Show();
        }

        private void adc_nhanvien_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị form Nhân Viên bên trong FluentDesignFormContainer
            frmNhanVien nhanVienForm = new frmNhanVien();
            nhanVienForm.TopLevel = false;
            nhanVienForm.FormBorderStyle = FormBorderStyle.None;
            nhanVienForm.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Clear();
            fluentDesignFormContainer1.Controls.Add(nhanVienForm);
            nhanVienForm.Show();
        }
    }
}
