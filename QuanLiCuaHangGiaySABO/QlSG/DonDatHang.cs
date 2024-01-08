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

        public frmDonDatHang()
        {
            InitializeComponent();
            // Cấu hình PrintDocument
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);

            // Khởi tạo và cấu hình PrintDialog
            printDialog1 = new System.Windows.Forms.PrintDialog();
            printDialog1.Document = printDocument1;

        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();
            showdata();
            dgvHoaDonDat.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            
            dgvHoaDonDat.Columns["NgayDatHang"].HeaderText = "Ngày Đặt Hàng";
            dgvHoaDonDat.Columns["Gia"].HeaderText = "Gía";
            dgvHoaDonDat.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgvHoaDonDat.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvHoaDonDat.Columns["Gia"].DefaultCellStyle.Format = "N0";
            dgvHoaDonDat.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            dgvtruyenhoadon.Columns.Add("TenSanPham", "Tên Sản Phẩm");
            dgvtruyenhoadon.Columns.Add("SoLuong", "Số Lượng");
            dgvtruyenhoadon.Columns.Add("Gia", "Giá");
            dgvtruyenhoadon.Columns.Add("ThanhTien", "Thành Tiền");
            dgvtruyenhoadon.Columns.Add("ThanhTien2", "Tổng Tiền");
            dgvtruyenhoadon.RowsAdded += dgvtruyenhoadon_RowsAdded;
            dgvtruyenhoadon.RowsRemoved += dgvtruyenhoadon_RowsRemoved;
        }
        private void showdata()
        {
            // Lấy thông tin tất cả đơn đặt hàng từ cơ sở dữ liệu
            var rs = from hd in db.HoaDons
                     join ct in db.ChiTietHoaDons on hd.MaHoaDon equals ct.MaHoaDon
                     join sp in db.SanPhams on ct.MaSanPham equals sp.MaSanPham
                     select new
                     {
                         hd.NgayDatHang,
                         sp.TenSanPham,
                         ct.SoLuong,
                         sp.Gia,
                         ThanhTien = ct.SoLuong * sp.Gia
                     };

            dgvHoaDonDat.DataSource = rs.ToList();
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
            }

        }
        private void sb_themhd_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường dữ liệu nhập
            string tenGiay = cbe_tengiay.Text;
            int soLuong = Convert.ToInt32(te_sl.Text);

            // Kiểm tra tính hợp lệ của dữ liệu nhập
            if (string.IsNullOrEmpty(tenGiay) || soLuong <= 0)
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy thông tin sản phẩm từ tên giày
            var sanPham = db.SanPhams.FirstOrDefault(sp => sp.TenSanPham == tenGiay);

            if (sanPham != null)
            {
                // Tạo mới đơn đặt hàng
                HoaDon donDatHang = new HoaDon
                {
                    NgayDatHang = DateTime.Now,
                    // Thêm các thông tin khác của đơn đặt hàng nếu cần
                };

                // Thêm đơn đặt hàng vào cơ sở dữ liệu
                db.HoaDons.InsertOnSubmit(donDatHang);
                db.SubmitChanges();

                // Tạo mới chi tiết đơn đặt hàng
                ChiTietHoaDon chiTiet = new ChiTietHoaDon
                {
                    MaHoaDon = donDatHang.MaHoaDon,
                    MaSanPham = sanPham.MaSanPham,
                    SoLuong = soLuong,
                    // Thêm các thông tin khác của chi tiết đơn đặt hàng nếu cần
                };

                // Thêm chi tiết đơn đặt hàng vào cơ sở dữ liệu
                db.ChiTietHoaDons.InsertOnSubmit(chiTiet);
                db.SubmitChanges();

                // Hiển thị thông báo thành công hoặc thực hiện các hành động khác
                XtraMessageBox.Show("Thêm đơn đặt hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật DataGridView hoặc làm các công việc khác nếu cần
                showdata();
            }
            else
            {
                XtraMessageBox.Show("Không tìm thấy sản phẩm. Vui lòng kiểm tra lại thông tin giày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dgvHoaDonDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvHoaDonDat.Rows[e.RowIndex];
                cbe_tengiay.Text = r.Cells["TenSanPham"].Value.ToString();
                te_gia.Text = r.Cells["Gia"].Value.ToString();
                te_sl.Text = r.Cells["SoLuong"].Value.ToString();
                te_tong.Text = r.Cells["ThanhTien"].Value.ToString();

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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // Gọi hàm in hóa đơn khi người dùng ấn nút In Hóa Đơn
            InHoaDon();
        }


        private void simpleButton3_Click(object sender, EventArgs e)
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
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
                string soLuong = row.Cells["SoLuong"].Value.ToString();
                string gia = row.Cells["Gia"].Value.ToString();
                string thanhTien = row.Cells["ThanhTien"].Value.ToString();

                string line = $"{tenSanPham}: Số lượng {soLuong}, Giá {gia}, Thành tiền {thanhTien}";
                e.Graphics.DrawString(line, font, Brushes.Black, xPos, yPos);
                yPos += 20;
            }

            e.Graphics.DrawLine(new Pen(Color.Black), xPos, yPos, 600, yPos);
            yPos += 20;

            // Vẽ tổng tiền
            string tongTien = dgvtruyenhoadon.Rows[dgvtruyenhoadon.Rows.Count - 1].Cells["ThanhTien2"].Value.ToString();
            string tongTienLine = $"Tổng tiền: {tongTien}";
            e.Graphics.DrawString(tongTienLine, font, Brushes.Black, xPos, yPos);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvHoaDonDat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvHoaDonDat.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvHoaDonDat.Rows[e.RowIndex];
                string tenSanPham = selectedRow.Cells["TenSanPham"].Value.ToString();
                int soLuong = Convert.ToInt32(selectedRow.Cells["SoLuong"].Value);
                double gia = Convert.ToDouble(selectedRow.Cells["Gia"].Value);
                double thanhTien = Convert.ToDouble(selectedRow.Cells["ThanhTien"].Value);

                dgvtruyenhoadon.Rows.Add(tenSanPham, soLuong, gia, thanhTien);
                TinhTongTien();
                daChonHang = true;
            }
            else
            {
                daChonHang = false;
                MessageBox.Show("Chưa chọn hàng nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng của Main và hiển thị nó
            Main mainForm = new Main(loginForm);
            mainForm.Show();

            // Đóng form hiện tại
            this.Close();
        }
    }

}