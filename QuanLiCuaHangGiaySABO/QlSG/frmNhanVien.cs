using DevExpress.XtraSpellChecker.Parser;
using QuanLiCuaHangGiaySABO.QlSG;
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
        private frmLogin loginForm;
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
            dgvNhanVien.Columns["TenNhanVien"].HeaderText = "Họ và Tên";
            dgvNhanVien.Columns["SoDienThoai"].HeaderText = "SĐT";
            dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["VaiTro"].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void showdata()
        {
            var rs = from nv in db.NhanViens
                     select new
                     {
                        nv.TenNhanVien,
                        nv.SoDienThoai,
                        nv.Email,
                        nv.DiaChi,
                        nv.VaiTro                       
                     };
            dgvNhanVien.DataSource = rs;
        }

        private bool KiemTraSDTTrungLap(string sdt)
        {
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (row.Cells["SoDienThoai"].Value != null && row.Cells["SoDienThoai"].Value.ToString() == sdt)
                {
                    return true; // SĐT đã tồn tại
                }
            }
            return false; // SĐT không trùng lặp
        }  

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvNhanVien.Rows[e.RowIndex];
                txthoten.Text = r.Cells["TenNhanVien"].Value.ToString();
                txtdiachi.Text = r.Cells["DiaChi"].Value.ToString();
                txtsdt.Text = r.Cells["SoDienThoai"].Value.ToString();
                txtchucvu.Text = r.Cells["VaiTro"].Value.ToString();
                txtemail.Text = r.Cells["Email"].Value.ToString();
            }
        }

        private void sbsua_Click(object sender, EventArgs e)
        {
            if (r == null)//Khong co dong nao duoc chon
            {
                MessageBox.Show("Vui Lòng chọn nhân viên cần cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nv = db.NhanViens.SingleOrDefault(x => x.Email == r.Cells["Email"].Value.ToString());
                    
                nv.TenNhanVien = txthoten.Text;
                nv.SoDienThoai = txtsdt.Text;              
                nv.DiaChi = txtdiachi.Text;
                db.SubmitChanges();
                MessageBox.Show("Cập Nhật thành công", "Thông báo", MessageBoxButtons.OK);
                showdata();
                //reset lại các trường thuộc tính
                txthoten.Text = txtsdt.Text = txtdiachi.Text = null;
                r = null;
            
            
        }

        private void sbxoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui Lòng chọn nhân viên cần xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (
                MessageBox.Show("bạn thực sự muốn xóa nhân viên này" + r.Cells["TenNhanVien"].Value.ToString() + "?", "Xác Nhận Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var nv = db.NhanViens.SingleOrDefault(x => x.TenNhanVien == r.Cells["TenNhanVien"].Value.ToString());
                    db.NhanViens.DeleteOnSubmit(nv);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    showdata();
                    //reset lại các trường thuộc tính
                    txthoten.Text = txtsdt.Text = txtdiachi.Text = txtchucvu.Text = null;
                    r = null;
                }
                catch
                {
                    MessageBox.Show("Không Thể Xóa Nhân Viên Này", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void sbtimkiem_Click(object sender, EventArgs e)
        {
            string tenNhanVienCanTim = txttimkiem.Text;

            if (!string.IsNullOrEmpty(tenNhanVienCanTim))
            {
                // Gọi hàm thực hiện tìm kiếm
                TimKiemTheoTenNhanVien(tenNhanVienCanTim);
            }
            else
            {
                // Hiển thị thông báo nếu không có tên nhân viên được nhập
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm kiếm.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Hàm thực hiện tìm kiếm theo tên nhân viên
        private void TimKiemTheoTenNhanVien(string tenNhanVien)
        {
            var ketQuaTimKiem = from nv in db.NhanViens
                                where nv.TenNhanVien.Contains(tenNhanVien)
                                select new
                                {
                                    nv.TenNhanVien,
                                    nv.VaiTro,
                                    nv.SoDienThoai,
                                    nv.Email,                                    
                                    nv.DiaChi
                                };

            dgvNhanVien.DataSource = ketQuaTimKiem.ToList();
        }

        private void sbloc_Click(object sender, EventArgs e)
        {
            string tenNhanVienCanLoc = txtloc.Text;

            if (!string.IsNullOrEmpty(tenNhanVienCanLoc))
            {
                // Gọi hàm thực hiện lọc
                LocTheoTenNhanVien(tenNhanVienCanLoc);
            }
            else
            {
                // Hiển thị thông báo nếu không có tên nhân viên được nhập
                MessageBox.Show("Vui lòng nhập tên nhân viên cần lọc.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LocTheoTenNhanVien(string tenNhanVien)
        {
            var ketQuaLoc = from nv in db.NhanViens
                            where nv.TenNhanVien.Contains(tenNhanVien)
                            select new
                            {
                                nv.TenNhanVien,
                                nv.VaiTro,
                                nv.SoDienThoai,
                                nv.Email,
                                nv.DiaChi
                            };

            dgvNhanVien.DataSource = ketQuaLoc.ToList();
        }

        private void frmNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
            string text = txtsdt.Text;

            // Kiểm tra xem mỗi ký tự có phải là số không
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    // Nếu có ký tự không phải là số, loại bỏ nó
                    txtsdt.Text = txtsdt.Text.Replace(c.ToString(), "");
                    MessageBox.Show("Vui lòng nhập chỉ số điện thoại.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Kiểm tra nếu độ dài của số điện thoại lớn hơn 10, cắt đi phần dư
            if (text.Length > 10)
            {
                txtsdt.Text = text.Substring(0, 10);
                MessageBox.Show("Không được nhập quá 10 số điện thoại.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        //private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        //{

        //}

    }
}
