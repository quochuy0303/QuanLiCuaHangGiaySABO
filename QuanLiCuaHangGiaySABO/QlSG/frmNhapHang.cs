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
    public partial class frmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;
        private DataGridViewRow r;
        public event Action<SanPham> NhapHangThanhCong;
        public frmNhapHang()
        {
            InitializeComponent();
            db = new bangiayDataContext();
        }


    }
}