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
    public partial class frmQuyenHan : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;
        public frmQuyenHan()
        {
            InitializeComponent();
        }

        private void showdata()
        {
            var rs = from qh in db.QuyenHanNhanViens
                     select new
                     {
                         qh.RoleName

                     };

            dgvQH.DataSource = rs;
        }

        private void frmQuyenHan_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();
            showdata();
        }
    }
}