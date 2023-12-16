using DevExpress.XtraSpellChecker.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiCuaHangGiaySABO
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private bangiayDataContext db;
        private DataGridViewRow r;

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();
            showdata();
            dgvNhanVien.Columns["Hoten"].HeaderText = "Họ Và Tên";
            dgvNhanVien.Columns["Position"].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns["PhoneNumber"].HeaderText = "SDT";
            dgvNhanVien.Columns["StartDate"].HeaderText = "Ngày làm";
            dgvNhanVien.Columns["Address"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns["Hoten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns["StartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void showdata()
        {
            var rs = from nv in db.nhanviens
                     select new
                     {
                         nv.Hoten,
                         nv.Position,
                         nv.PhoneNumber,
                         nv.StartDate,
                         nv.Address

                     };
            dgvNhanVien.DataSource = rs;
        }
    }
}
