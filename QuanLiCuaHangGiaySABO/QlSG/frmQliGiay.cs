using DevExpress.Utils.Gesture;
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
    public partial class frmQliGiay : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;
        private DataGridViewRow r;
        public frmQliGiay()
        {
            InitializeComponent();
        }

        private void frmQliGiay_Load(object sender, EventArgs e)
        {
            try
            {
                db = new bangiayDataContext();


                showdata();
                LoadSizeOptions();
                dgvSP.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
                dgvSP.Columns["MaSanPhamCode"].HeaderText = "Code Sản Phẩm";
                dgvSP.Columns["Gia"].HeaderText = "Giá";
                dgvSP.Columns["SoLuongTon"].HeaderText = "Số Lượng";
                dgvSP.Columns["MoTa"].HeaderText = "Mô Tả";
                dgvSP.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSP.Columns["MoTa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvSP.Columns["Gia"].DefaultCellStyle.Format = "N0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            

        }
        private void showdata()
        {
            var rs = from sp in db.SanPhams

                     select new
                     {
                         sp.TenSanPham,
                         sp.MaSanPhamCode,
                         sp.Size,
                         sp.Gia,
                         sp.SoLuongTon,
                         sp.MoTa
                         
                         
                     };
            dgvSP.DataSource = rs;    
        }

        private void LoadSizeOptions()
        {
            // Đảm bảo rằng ComboBox đã được xóa các mục cũ trước khi thêm mục mới
            cbe_size.Properties.Items.Clear();

            // Truy vấn lấy danh sách các kích cỡ duy nhất từ cột Size của bảng SanPham
            var sizeOptions = db.SanPhams.Select(sp => sp.Size).Distinct().ToList();

            // Thêm danh sách SizeOptions vào ComboBox
            cbe_size.Properties.Items.AddRange(sizeOptions);

            // Chọn mục đầu tiên nếu có
            if (cbe_size.Properties.Items.Count > 0)
            {
                cbe_size.SelectedIndex = 0;
            }
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự đang được nhập có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự nếu không phải là số
            }
        }
    }
}