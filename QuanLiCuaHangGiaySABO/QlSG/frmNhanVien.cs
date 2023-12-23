using DevExpress.XtraSpellChecker.Parser;
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
            dgvNhanVien.Columns["Hoten"].HeaderText = "Họ Và Tên";
            dgvNhanVien.Columns["Position"].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns["PhoneNumber"].HeaderText = "SDT";
            dgvNhanVien.Columns["StartDate"].HeaderText = "Ngày làm";
            dgvNhanVien.Columns["Address"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns["Hoten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns["StartDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void showdata()
        {
            var rs = from nv in db.nhanviens
                     select new
                     {
                         nv.Hoten,
                         nv.Position,
                         nv.PhoneNumber,
                         nv.Email,
                         nv.StartDate,
                         nv.Address

                     };
            dgvNhanVien.DataSource = rs;
        }

        private bool KiemTraSDTTrungLap(string sdt)
        {
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (row.Cells["PhoneNumber"].Value != null && row.Cells["PhoneNumber"].Value.ToString() == sdt)
                {
                    return true; // SĐT đã tồn tại
                }
            }
            return false; // SĐT không trùng lặp
        }

        private void sbthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txthoten.Text) ||
           string.IsNullOrWhiteSpace(txtemail.Text) ||
           string.IsNullOrWhiteSpace(txtsdt.Text) ||
           string.IsNullOrWhiteSpace(txtdiachi.Text) ||
           string.IsNullOrWhiteSpace(txtchucvu.Text) ||
           string.IsNullOrWhiteSpace(txtngaylam.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sdt = txtsdt.Text;
            if (KiemTraSDTTrungLap(sdt))
            {
                MessageBox.Show("Số điện thoại đã tồn tại trong danh sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nhanvien nv = new nhanvien();
            nv.Hoten = txthoten.Text;
            nv.PhoneNumber = txtsdt.Text;
            nv.Email = txtemail.Text;
            nv.Address = txtdiachi.Text;
            nv.Position = txtchucvu.Text;
            if (DateTime.TryParse(txtngaylam.Text, out DateTime ngayLam))
            {
                // Chuyển đổi thành công, gán giá trị cho thuộc tính StartDate
                nv.StartDate = ngayLam;
            }
            else
            {
                // Ngày nhập vào không hợp lệ, có thể hiển thị thông báo lỗi
                MessageBox.Show("Ngày làm không hợp lệ. Vui lòng nhập theo định dạng đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.nhanviens.InsertOnSubmit(nv);//thêm vào dgv
            db.SubmitChanges();//lưu vào csdl
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            showdata();
            //reset lại các trường thuộc tính
            txthoten.Text = txtsdt.Text = txtemail.Text = txtdiachi.Text = txtchucvu.Text = txtngaylam.Text = null;
            r = null;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvNhanVien.Rows[e.RowIndex];
                txthoten.Text = r.Cells["Hoten"].Value.ToString();
                txtsdt.Text = r.Cells["PhoneNumber"].Value.ToString();
                txtemail.Text = r.Cells["Email"].Value.ToString();
                txtdiachi.Text = r.Cells["Address"].Value.ToString();
                txtchucvu.Text = r.Cells["Position"].Value.ToString();
                txtngaylam.Text = r.Cells["StartDate"].Value.ToString();
            }
        }

        private void sbsua_Click(object sender, EventArgs e)
        {
            if (r == null)//Khong co dong nao duoc chon
            {
                MessageBox.Show("Vui Lòng chọn nhân viên cần cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            var nv = db.nhanviens.SingleOrDefault(x => x.Hoten == r.Cells["Hoten"].Value.ToString());

            nv.Hoten = txthoten.Text;
            nv.PhoneNumber = txtsdt.Text;
            nv.Email = txtemail.Text;
            nv.Address = txtdiachi.Text;
            nv.Position = txtchucvu.Text;
            if (DateTime.TryParse(txtngaylam.Text, out DateTime ngayLam))
            {
                // Chuyển đổi thành công, gán giá trị cho thuộc tính StartDate
                nv.StartDate = ngayLam;
            }
            else
            {
                // Ngày nhập vào không hợp lệ, có thể hiển thị thông báo lỗi
                MessageBox.Show("Ngày làm không hợp lệ. Vui lòng nhập theo định dạng đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.SubmitChanges();
            MessageBox.Show("Cập Nhật thành công", "Thông báo", MessageBoxButtons.OK);
            showdata();
            //reset lại các trường thuộc tính
            txthoten.Text = txtsdt.Text = txtemail.Text = txtdiachi.Text = txtchucvu.Text = txtngaylam.Text =  null;
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
                MessageBox.Show("bạn thực sự muốn xóa nhân viên này" + r.Cells["username"].Value.ToString() + "?", "Xác Nhận Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var nv = db.nhanviens.SingleOrDefault(x => x.Hoten == r.Cells["Hoten"].Value.ToString());
                    db.nhanviens.DeleteOnSubmit(nv);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    showdata();
                    //reset lại các trường thuộc tính
                    txthoten.Text = txtsdt.Text = txtemail.Text = txtdiachi.Text = txtchucvu.Text = txtngaylam.Text = null;
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
            var ketQuaTimKiem = from nv in db.nhanviens
                                where nv.Hoten.Contains(tenNhanVien)
                                select new
                                {
                                    nv.Hoten,
                                    nv.Position,
                                    nv.PhoneNumber,
                                    nv.Email,
                                    nv.StartDate,
                                    nv.Address
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
            var ketQuaLoc = from nv in db.nhanviens
                            where nv.Hoten.Contains(tenNhanVien)
                            select new
                            {
                                nv.Hoten,
                                nv.Position,
                                nv.PhoneNumber,
                                nv.Email,
                                nv.StartDate,
                                nv.Address
                            };

            dgvNhanVien.DataSource = ketQuaLoc.ToList();
        }
    }
}
