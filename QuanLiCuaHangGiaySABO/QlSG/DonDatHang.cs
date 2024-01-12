using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
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
    public partial class frmDonDatHang : DevExpress.XtraEditors.XtraForm
    {
        private bangiayDataContext db;
        private DataGridViewRow r;
        private frmLogin loginForm;
        private bool daChonHang = false;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private double tongTienDonDatHang;

        public frmDonDatHang()
        {
            InitializeComponent();
            // Cấu hình PrintDocument
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);

            // Khởi tạo và cấu hình PrintDialog
            printDialog1 = new System.Windows.Forms.PrintDialog();
            printDialog1.Document = printDocument1;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);

        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();
            try
            {
                // Lấy danh sách tên sản phẩm từ cơ sở dữ liệu
                var tenSanPhamList = db.SanPhams.Select(sp => sp.TenSanPham).ToList();

                // Đặt danh sách làm nguồn dữ liệu cho ComboBox
                cbe_tengiay.Properties.Items.AddRange(tenSanPhamList);

                if (cbe_tengiay.Properties.Items.Count > 0)
                {
                    // Chọn mặc định một giá trị nếu cần thiết
                    cbe_tengiay.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu tên sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadSizes();
            showdata();
            dgvHoaDonDat.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgvHoaDonDat.Columns["NgayDatHang"].HeaderText = "Ngày Đặt Hàng";
            dgvHoaDonDat.Columns["SoLuong"].HeaderText = "Số Lượng";
           // dgvHoaDonDat.Columns["TenSize"].HeaderText = "Size";
            dgvHoaDonDat.Columns["Gia"].HeaderText = "Gía";
            dgvHoaDonDat.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgvHoaDonDat.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHoaDonDat.Columns["Gia"].DefaultCellStyle.Format = "N0";
            dgvHoaDonDat.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            dgvtruyenhoadon.Columns.Add("TenSanPham", "Tên Sản Phẩm");
            dgvtruyenhoadon.Columns.Add("Size", "Size");
            dgvtruyenhoadon.Columns.Add("SoLuong", "Số Lượng");
            dgvtruyenhoadon.Columns.Add("Gia", "Giá");
            dgvtruyenhoadon.Columns.Add("ThanhTien", "Thành Tiền");
            dgvtruyenhoadon.Columns.Add("ThanhTien2", "Tổng Tiền");
            dgvtruyenhoadon.Columns["Size"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvtruyenhoadon.RowsAdded += dgvtruyenhoadon_RowsAdded;
            dgvtruyenhoadon.RowsRemoved += dgvtruyenhoadon_RowsRemoved;
        }
        private void showdata()
        {
            try
            {
                // Lấy thông tin tất cả đơn đặt hàng từ cơ sở dữ liệu
                var rs = from hd in db.HoaDons
                         join ct in db.ChiTietHoaDons on hd.MaHoaDon equals ct.MaHoaDon
                         join sp in db.SanPhams on ct.MaSanPham equals sp.MaSanPham
                         join size in db.SizeGiays on sp.SizeGiayID equals size.SizeID into sizeGroup
                         from size in sizeGroup.DefaultIfEmpty() // Left Join
                         select new
                         {
                             hd.NgayDatHang,
                             sp.TenSanPham,
                             Size = (size != null) ? size.TenSize : "Chưa có size", // Hiển thị "Chưa có size" nếu không có kết quả từ SizeGiays
                             ct.SoLuong,
                             sp.Gia,
                             ThanhTien = ct.SoLuong * sp.Gia
                         };

                dgvHoaDonDat.DataSource = rs.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu đơn đặt hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSizes()
        {
            try
            {
                // Giả sử bạn có một bảng Size trong cơ sở dữ liệu
                var sizeList = db.SizeGiays.Select(size => size.TenSize).ToList();

                // Đặt sizeList làm nguồn dữ liệu cho ComboBox
                cbe_size.Properties.Items.AddRange(sizeList);

                if (cbe_size.Properties.Items.Count > 0)
                {
                    // Chọn size đầu tiên mặc định
                    cbe_size.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu size giày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy dữ liệu size giày: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvtruyenhoadon_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // Tính lại tổng tiền khi có sự thay đổi trong dgvtruyenhoadon
            TinhTongTien();
        }

        private void dgvtruyenhoadon_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Tính lại tổng tiền khi có sự thay đổi trong dgvtruyenhoadon
            TinhTongTien();
        }

        private void TinhTongTien()
        {
            double tongTien = 0;

            foreach (DataGridViewRow row in dgvtruyenhoadon.Rows)
            {
                if (row.Cells["ThanhTien"] != null)
                {
                    double thanhTien = Convert.ToDouble(row.Cells["ThanhTien"].Value);
                    row.Cells["ThanhTien2"].Value = thanhTien;
                    tongTien += thanhTien;
                }
            }

            // Cập nhật tổng tiền vào hàng cuối cùng của dgvtruyenhoadon
            if (dgvtruyenhoadon.Rows.Count > 0)
            {
                dgvtruyenhoadon.Rows[dgvtruyenhoadon.Rows.Count - 1].Cells["ThanhTien2"].Value = tongTien;

                // Cập nhật giá trị tổng tiền của form
                tongTienDonDatHang = tongTien;
            }      

    }
     
       
        private void InHoaDon()
        {
            DialogResult result = printDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }
     
      
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Cập nhật số lượng sản phẩm sau khi in hóa đơn
            foreach (DataGridViewRow row in dgvtruyenhoadon.Rows)
            {
                int maSanPham = GetMaSanPhamFromTenSanPham(row.Cells["TenSanPham"].Value.ToString());
                int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

                // Lấy thông tin sản phẩm từ bảng SanPhams
                var sanPham = db.SanPhams.SingleOrDefault(sp => sp.MaSanPham == maSanPham);

                if (sanPham != null)
                {
                    // Cập nhật số lượng sản phẩm
                    sanPham.SoLuong -= soLuong;
                }
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            db.SubmitChanges();

            // In thông tin liên hệ và chi tiết đơn đặt hàng
            Font font = new Font("Arial", 12, FontStyle.Regular);
            float yPos = 100;
            float xPos = 50;

            // In thông tin liên hệ
            e.Graphics.DrawString("Tên Cửa Hàng: Cửa Hàng Giày SABO", font, Brushes.Black, xPos, yPos);
            yPos += 20;
            e.Graphics.DrawString("Địa Chỉ: 180 Đường Linh Xuân, Thủ Đức, Thành Phố HCM", font, Brushes.Black, xPos, yPos);
            yPos += 20;
            e.Graphics.DrawString("Hotline: 0922223583", font, Brushes.Black, xPos, yPos);
            yPos += 40;

            // In chi tiết đơn đặt hàng
            foreach (DataGridViewRow row in dgvtruyenhoadon.Rows)
            {
                string tenSanPham = row.Cells["TenSanPham"].Value.ToString();
                string sizegiay = row.Cells["Size"].Value.ToString(); 
                string soLuong = row.Cells["SoLuong"].Value.ToString();
                string gia = row.Cells["Gia"].Value.ToString();
                string thanhTien = row.Cells["ThanhTien"].Value.ToString();

                string line = $"{tenSanPham}:  Size {sizegiay}  Số lượng {soLuong}   Giá {gia}     Thành tiền {thanhTien}";
                e.Graphics.DrawString(line, font, Brushes.Black, xPos, yPos);
                yPos += 20;
            }

            e.Graphics.DrawLine(new Pen(Color.Black), xPos, yPos, 600, yPos);
            yPos += 20;

            // Vẽ tổng tiền
            string tongTien = dgvtruyenhoadon.Rows[dgvtruyenhoadon.Rows.Count - 1].Cells["ThanhTien2"].Value.ToString();
            string tongTienLine = $"Tổng tiền: {tongTien}";
            e.Graphics.DrawString(tongTienLine, font, Brushes.Black, xPos, yPos);
            // Cập nhật dgvLSGD trong frmLSGD
            CapNhatDgvLSGDFormLSGD();
        }

        // Lấy mã sản phẩm vì mã sp của từng sản phẩm là độc nhất
        private int GetMaSanPhamFromTenSanPham(string tenSanPham)
        {
            // Hàm này để lấy mã sản phẩm từ tên sản phẩm
            var sanPham = db.SanPhams.SingleOrDefault(sp => sp.TenSanPham == tenSanPham);
            return (sanPham != null) ? sanPham.MaSanPham : -1;
        }
          
        

        private void sb_themhd_Click_1(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường dữ liệu nhập
            string tenGiay = cbe_tengiay.Text;

            // Kiểm tra nếu có mục được chọn trong ComboBox Size
            if (cbe_size.SelectedItem != null)
            {
                string tenSize = cbe_size.SelectedItem.ToString();
                int soLuong = Convert.ToInt32(te_sl.Text);

                // Kiểm tra tính hợp lệ của dữ liệu nhập
                if (string.IsNullOrEmpty(tenGiay) || string.IsNullOrEmpty(tenSize) || soLuong <= 0)
                {
                    XtraMessageBox.Show("Vui lòng nhập thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy thông tin sản phẩm từ tên giày
                var sanPham = db.SanPhams.FirstOrDefault(sp => sp.TenSanPham == tenGiay);

                if (sanPham != null)
                {
                    // Lấy thông tin Size từ cơ sở dữ liệu
                    var size = db.SizeGiays.FirstOrDefault(sz => sz.TenSize == tenSize);

                    // Kiểm tra xem size có tồn tại không (thực hiện kiểm tra dư thừa)
                    if (size == null)
                    {
                        // Nếu size không tồn tại, thêm mới size vào cơ sở dữ liệu
                        size = new SizeGiay { TenSize = tenSize };
                        db.SizeGiays.InsertOnSubmit(size);
                        db.SubmitChanges();
                    }

                    // Tạo mới đơn đặt hàng
                    HoaDon donDatHang = new HoaDon
                    {
                        NgayDatHang = DateTime.Now,
                        // Thêm các thông tin khác của đơn đặt hàng nếu cần
                    };

                    // Thêm đơn đặt hàng vào cơ sở dữ liệu
                    db.HoaDons.InsertOnSubmit(donDatHang);
                    db.SubmitChanges();

                    ChiTietHoaDon chiTiet = new ChiTietHoaDon
                    {
                        MaHoaDon = donDatHang.MaHoaDon,
                        MaSanPham = sanPham.MaSanPham,
                        SoLuong = soLuong,
                        SizeGiayID = size.SizeID
                    };

                    // Thêm chi tiết đơn đặt hàng vào cơ sở dữ liệu
                    db.ChiTietHoaDons.InsertOnSubmit(chiTiet);
                    db.SubmitChanges();

                    // Cập nhật DataGridView
                    showdata();

                    // Cập nhật giá trị của cột Size sau khi thêm
                    if (r != null)
                    {
                        r.Cells["TenSize"].Value = size.TenSize;
                    }

                    // Hiển thị thông báo thành công hoặc thực hiện các hành động khác
                    XtraMessageBox.Show("Thêm đơn đặt hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Không tìm thấy sản phẩm. Vui lòng kiểm tra lại thông tin giày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn một size giày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            if (daChonHang)
            {
                int rowIndex = dgvtruyenhoadon.Rows.Count - 1;

                if (rowIndex >= 0)
                {
                    dgvtruyenhoadon.Rows.RemoveAt(rowIndex);
                    TinhTongTien();
                    MessageBox.Show("Hủy hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            InHoaDon();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của Main và hiển thị nó
            Main mainForm = new Main(loginForm);
            mainForm.Show();

            // Đóng form hiện tại
            this.Close();
        }

        private void dgvHoaDonDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvHoaDonDat.Rows[e.RowIndex];
                cbe_tengiay.Text = r.Cells["TenSanPham"].Value.ToString();
                cbe_size.Text = r.Cells["Size"].Value.ToString();
                te_gia.Text = r.Cells["Gia"].Value.ToString();
                te_sl.Text = r.Cells["SoLuong"].Value.ToString();
                te_tong.Text = r.Cells["ThanhTien"].Value.ToString();

            }
        }

        private void dgvHoaDonDat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHoaDonDat.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvHoaDonDat.Rows[e.RowIndex];
                string tenSanPham = selectedRow.Cells["TenSanPham"].Value.ToString();
                string sizegiay = selectedRow.Cells["Size"].Value.ToString();
                int soLuong = Convert.ToInt32(selectedRow.Cells["SoLuong"].Value);
                double gia = Convert.ToDouble(selectedRow.Cells["Gia"].Value);
                double thanhTien = Convert.ToDouble(selectedRow.Cells["ThanhTien"].Value);

                dgvtruyenhoadon.Rows.Add(tenSanPham, sizegiay, soLuong, gia, thanhTien);
                TinhTongTien();
                daChonHang = true;
            }
            else
            {
                daChonHang = false;
                MessageBox.Show("Chưa chọn hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Mở form frmLSGD và truyền tham chiếu của frmLSGD
            frmLSGD lsgdForm = new frmLSGD();

            // Truyền giá trị tổng tiền qua frmLSGD
            lsgdForm.TongTienDonDatHang = tongTienDonDatHang;  // Đảm bảo cập nhật giá trị này từ frmDonDatHang

            lsgdForm.CapNhatDgvLSGD(); // Cập nhật dữ liệu cho dgvLSGD khi mở form
            lsgdForm.ShowDialog();
        }
        private void CapNhatDgvLSGDFormLSGD()
        {
            if (Application.OpenForms["frmLSGD"] is frmLSGD frmLSGD)
            {
                frmLSGD.CapNhatDgvLSGD();
            }
        }

    }

}