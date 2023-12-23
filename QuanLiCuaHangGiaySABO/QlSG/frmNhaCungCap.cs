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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private bangiayDataContext db;
        private DataGridViewRow r;
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();
            showdata();
            dgvNCC.Columns["TenNhaCungCap"].HeaderText = "Tên Nhà Cung Cấp";
            dgvNCC.Columns["SoDienThoaiNhaCungCap"].HeaderText = "SDT";
            dgvNCC.Columns["EmailNhaCungCap"].HeaderText = "Email";
            dgvNCC.Columns["DiaChiNhaCungCap"].HeaderText = "Địa Chỉ";
            dgvNCC.Columns["DiaChiNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNCC.Columns["TenNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNCC.Columns["EmailNhaCungCap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void showdata()
        {
            var rs = from nv in db.NhaCungCaps
                     select new
                     {
                         nv.TenNhaCungCap,                        
                         nv.SoDienThoaiNhaCungCap,
                         nv.DiaChiNhaCungCap,
                         nv.EmailNhaCungCap

                     };

            dgvNCC.DataSource = rs;
        }

        private void sbthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txthoten.Text) ||
          string.IsNullOrWhiteSpace(txtemail.Text) ||
          string.IsNullOrWhiteSpace(txtsdt.Text) ||
          string.IsNullOrWhiteSpace(txtdiachi.Text))

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

            NhaCungCap nv = new NhaCungCap();
            nv.TenNhaCungCap = txthoten.Text;
            nv.SoDienThoaiNhaCungCap = txtsdt.Text;
            nv.EmailNhaCungCap = txtemail.Text;
            nv.DiaChiNhaCungCap = txtdiachi.Text;

            db.NhaCungCaps.InsertOnSubmit(nv);//thêm vào dgv
            db.SubmitChanges();//lưu vào csdl
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            showdata();
            //reset lại các trường thuộc tính
            txthoten.Text = txtsdt.Text = txtemail.Text = txtdiachi.Text = null;
            r = null;
        }
        private bool KiemTraSDTTrungLap(string sdt)
        {
            foreach (DataGridViewRow row in dgvNCC.Rows)
            {
                if (row.Cells["SoDienThoaiNhaCungCap"].Value != null && row.Cells["SoDienThoaiNhaCungCap"].Value.ToString() == sdt)
                {
                    return true; // SĐT đã tồn tại
                }
            }
            return false; // SĐT không trùng lặp

        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvNCC.Rows[e.RowIndex];
                txthoten.Text = r.Cells["TenNhaCungCap"].Value.ToString();
                txtsdt.Text = r.Cells["SoDienThoaiNhaCungCap"].Value.ToString();
                txtemail.Text = r.Cells["EmailNhaCungCap"].Value.ToString();
                txtdiachi.Text = r.Cells["DiaChiNhaCungCap"].Value.ToString();

            }
        }

        private void sbsua_Click(object sender, EventArgs e)
        {
            if (r == null)//Khong co dong nao duoc chon
            {
                MessageBox.Show("Vui Lòng chọn nhân viên cần cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            var nv = db.NhaCungCaps.SingleOrDefault(x => x.TenNhaCungCap == r.Cells["TenNhaCungCap"].Value.ToString());

            nv.TenNhaCungCap = txthoten.Text;
            nv.SoDienThoaiNhaCungCap = txtsdt.Text;
            nv.EmailNhaCungCap = txtemail.Text;
            nv.DiaChiNhaCungCap = txtdiachi.Text;
            db.SubmitChanges();
            MessageBox.Show("Cập Nhật thành công", "Thông báo", MessageBoxButtons.OK);
            showdata();
            //reset lại các trường thuộc tính
            txthoten.Text = txtsdt.Text = txtemail.Text = txtdiachi.Text = null;
            r = null;
        }

        private void sbxoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui Lòng chọn Nhà Cung Cấp cần xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (
                MessageBox.Show("bạn thực sự muốn xóa Nhà Cung Cấp này" + r.Cells["TenNhaCungCap"].Value.ToString() + "?", "Xác Nhận Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var nv = db.NhaCungCaps.SingleOrDefault(x => x.TenNhaCungCap == r.Cells["TenNhaCungCap"].Value.ToString());
                    db.NhaCungCaps.DeleteOnSubmit(nv);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    showdata();
                    //reset lại các trường thuộc tính
                    txthoten.Text = txtsdt.Text = txtemail.Text = txtdiachi.Text = null;
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
            string tenNhaCungCapCanTim = txtTimKiemNCC.Text;

            if (!string.IsNullOrEmpty(tenNhaCungCapCanTim))
            {
                // Gọi hàm thực hiện tìm kiếm
                TimKiemTheoTenNhaCungCap(tenNhaCungCapCanTim);
            }
            else
            {
                // Hiển thị thông báo nếu không có tên nhân viên được nhập
                MessageBox.Show("Vui lòng nhập tên Nhà Cung Cấp cần tìm kiếm.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TimKiemTheoTenNhaCungCap(string tenNhaCungCap)
        {
            var ketQuaTimKiem = from nv in db.NhaCungCaps
                                where nv.TenNhaCungCap.Contains(tenNhaCungCap)
                                select new
                                {
                                    nv.TenNhaCungCap,
                                    nv.SoDienThoaiNhaCungCap,
                                    nv.EmailNhaCungCap,
                                    nv.DiaChiNhaCungCap

                                };

            dgvNCC.DataSource = ketQuaTimKiem.ToList();
        }

        private void txtLoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void sbloc_Click(object sender, EventArgs e)
        {
            string tenNhaCungCapCanLoc = txtLoc.Text;

            if (!string.IsNullOrEmpty(tenNhaCungCapCanLoc))
            {
                // Gọi hàm thực hiện lọc
                LocTheoTenNhaCungCap(tenNhaCungCapCanLoc);
            }
            else
            {
                // Hiển thị thông báo nếu không có tên nhân viên được nhập
                MessageBox.Show("Vui lòng nhập tên nhân viên cần lọc.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LocTheoTenNhaCungCap(string tenNhaCungCap)
        {
            var ketQuaLoc = from nv in db.NhaCungCaps
                            where nv.TenNhaCungCap.Contains(tenNhaCungCap)
                            select new
                            {
                                nv.TenNhaCungCap,
                                nv.SoDienThoaiNhaCungCap,
                                nv.EmailNhaCungCap,
                                nv.DiaChiNhaCungCap


                            };

            dgvNCC.DataSource = ketQuaLoc.ToList();
        }
    }
}