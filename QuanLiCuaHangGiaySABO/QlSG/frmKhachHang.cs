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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private bangiayDataContext db;
        private DataGridViewRow r;

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            db = new bangiayDataContext();
            showdata();           
        }
        private bool KiemTraSDTTrungLap(string sdt)
        {
            foreach (DataGridViewRow row in dgvKH.Rows)
            {
                if (row.Cells["SoDienThoai"].Value != null && row.Cells["SoDienThoai"].Value.ToString() == sdt)
                {
                    return true; // SĐT đã tồn tại
                }
            }
            return false; // SĐT không trùng lặp
        }

        private void showdata()
        {
            var rs = from kh in db.KhachHangs
                     select new
                     {
                         kh.TenKhachHang,                        
                         kh.SoDienThoai,
                         kh.DiaChiKhachHang

                     };

            dgvKH.DataSource = rs;
        }

        private void sbthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txthotenkh.Text) ||
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

            KhachHang nv = new KhachHang();
            nv.TenKhachHang = txthotenkh.Text;
            nv.SoDienThoai = txtsdt.Text;          
            nv.DiaChiKhachHang = txtdiachi.Text;
           
            db.KhachHangs.InsertOnSubmit(nv);//thêm vào dgv
            db.SubmitChanges();//lưu vào csdl
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            showdata();
            //reset lại các trường thuộc tính
            txthotenkh.Text = txtsdt.Text  = txtdiachi.Text  = null;
            r = null;
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
        }

        private void sbsua_Click(object sender, EventArgs e)
        {
            if (r == null)//Khong co dong nao duoc chon
            {
                MessageBox.Show("Vui Lòng chọn nhân viên cần cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            var nv = db.KhachHangs.SingleOrDefault(x => x.TenKhachHang == r.Cells["TenKhachHang"].Value.ToString());

            nv.TenKhachHang = txthotenkh.Text;
            nv.SoDienThoai = txtsdt.Text;          
            nv.DiaChiKhachHang = txtdiachi.Text;          
            db.SubmitChanges();
            MessageBox.Show("Cập Nhật thành công", "Thông báo", MessageBoxButtons.OK);
            showdata();
            //reset lại các trường thuộc tính
            txthotenkh.Text = txtsdt.Text = txtdiachi.Text = null;
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
                MessageBox.Show("bạn thực sự muốn xóa nhân viên này" + r.Cells["TenKhachHang"].Value.ToString() + "?", "Xác Nhận Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var nv = db.KhachHangs.SingleOrDefault(x => x.TenKhachHang == r.Cells["TenKhachHang"].Value.ToString());
                    db.KhachHangs.DeleteOnSubmit(nv);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    showdata();
                    //reset lại các trường thuộc tính
                    txthotenkh.Text = txtsdt.Text = txtdiachi.Text = null;
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
            string tenkhachHangCanTim = txttimkh.Text;

            if (!string.IsNullOrEmpty(tenkhachHangCanTim))
            {
                // Gọi hàm thực hiện tìm kiếm
                TimKiemTheoTenKhachHang(tenkhachHangCanTim);
            }
            else
            {
                // Hiển thị thông báo nếu không có tên nhân viên được nhập
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm kiếm.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txttimkh_TextChanged(object sender, EventArgs e)
        {

        }
        private void TimKiemTheoTenKhachHang(string tenKhachHang)
        {
            var ketQuaTimKiem = from nv in db.KhachHangs
                                where nv.TenKhachHang.Contains(tenKhachHang)
                                select new
                                {
                                    nv.TenKhachHang,
                                    nv.SoDienThoai,                                  
                                    nv.DiaChiKhachHang

                                };

            dgvKH.DataSource = ketQuaTimKiem.ToList();
        }

        private void sblockh_Click(object sender, EventArgs e)
        {
            string tenKhachHangCanLoc = txtlockh.Text;

            if (!string.IsNullOrEmpty(tenKhachHangCanLoc))
            {
                // Gọi hàm thực hiện lọc
                LocTheoTenKhachHang(tenKhachHangCanLoc);
            }
            else
            {
                // Hiển thị thông báo nếu không có tên nhân viên được nhập
                MessageBox.Show("Vui lòng nhập tên nhân viên cần lọc.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LocTheoTenKhachHang(string tenKhachHang)
        {
            var ketQuaLoc = from nv in db.KhachHangs
                            where nv.TenKhachHang.Contains(tenKhachHang)
                            select new
                            {
                                nv.TenKhachHang,
                                nv.SoDienThoai,                               
                                nv.DiaChiKhachHang


                            };

            dgvKH.DataSource = ketQuaLoc.ToList();
        }
    }
}