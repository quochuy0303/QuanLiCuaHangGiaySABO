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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private bangiayDataContext db;
        private DataGridViewRow r;
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();
            showdata();
            dgvNCC.Columns["TenNhaCungCap"].HeaderText = "Tên Nhà Cung Cấp";
            dgvNCC.Columns["SoDienThoaiNhaCungCap"].HeaderText = "SDT";
            dgvNCC.Columns["EmailNhaCungCap"].HeaderText = "Email";
            dgvNCC.Columns["DiaChiNhaCungCap"].HeaderText = "Địa Chỉ";
            dgvNCC.Columns["DiaChiNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNCC.Columns["TenNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNCC.Columns["EmailNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void showdata()
        {
            var rs = from nv in db.NhaCungCaps
                     select new
                     {
                         nv.TenNhaCungCap,                        
                         nv.SoDienThoaiNhaCungCap,
                         nv.DiaChiNhaCungCap,
                         nv.EmailNhaCungCap

                     };

            dgvNCC.DataSource = rs;
        }
    }
}