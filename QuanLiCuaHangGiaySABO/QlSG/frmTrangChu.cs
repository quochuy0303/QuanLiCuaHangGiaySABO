using DevExpress.XtraBars;
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
    public partial class frmTrangChu : DevExpress.XtraEditors.XtraForm
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void bi_nhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }

        private void bi_nhacungcap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            frm.Show();
        }
    }
}