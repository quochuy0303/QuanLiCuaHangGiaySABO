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
    public partial class frmKho : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;
      // private DataGridViewRow r;
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();

        }

        private void sbnhaphang_Click(object sender, EventArgs e)
        {
            // Mở form nhập hàng
            frmNhapHang formNhapHang = new frmNhapHang();

            // Đăng ký sự kiện để nhận thông tin sau khi nhập hàng
           // formNhapHang.NhapHangThanhCong += FormNhapHang_NhapHangThanhCong;

            formNhapHang.ShowDialog();
        }
    }
}