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
    public partial class DonDatHang : DevExpress.XtraEditors.XtraForm
    {
        bangiayDataContext db;
        public DonDatHang()
        {
            InitializeComponent();
        }

        private void DonDatHang_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();
            showdata();
        }
        private void showdata()
        {
            var rs = from nv in db.HoaDons
                     select new
                     {
                         nv.NgayDatHang,
                         
                     };

            dgvHoaDonDat.DataSource = rs;
        }
    }
}