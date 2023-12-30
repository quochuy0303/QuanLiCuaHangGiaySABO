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
            db = new bangiayDataContext();
            showdata();
            dgvSP.Columns["TenSanPham"].HeaderText = "Tên sản phẩm";
            dgvSP.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvSP.Columns["Gia"].HeaderText = "Gíá";
            dgvSP.Columns["MoTa"].HeaderText = "Mô tả ";
            dgvSP.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSP.Columns["MoTa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
                MessageBox.Show("Gía chỉ được nhập số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
        }
        private void showdata()
        {
            var rs = from sp in db.SanPhams
                     select new
                     {
                         sp.TenSanPham,
                         sp.SoLuong,
                         sp.Gia,
                         sp.MoTa


                     };
            dgvSP.DataSource = rs;
        }

        private void sbthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttengiay.Text) ||
          string.IsNullOrWhiteSpace(txtmota.Text) ||
                    string.IsNullOrWhiteSpace(txtgia.Text) ||
                    string.IsNullOrWhiteSpace(txtsoluong.Text))

            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SanPham nv = new SanPham();
            nv.TenSanPham = txttengiay.Text;
            nv.MoTa = txtmota.Text;
            // Lấy giá trị từ TextBox cho giá và số lượng
            string giaText = txtgia.Text;
            string soLuongText = txtsoluong.Text;

            // Chuyển đổi giá và số lượng sang kiểu int
            if (int.TryParse(giaText, out int gia) && int.TryParse(soLuongText, out int soLuong))
            {
                // Gán giá trị cho đối tượng NhanVien (nv)
                nv.Gia = gia;
                nv.SoLuong = soLuong;

                // Tiếp tục xử lý khác nếu cần
            }
            else
            {
                // Hiển thị thông báo lỗi nếu không thể chuyển đổi
                MessageBox.Show("Vui lòng nhập giá và số lượng là số nguyên.");
            }


            db.SanPhams.InsertOnSubmit(nv);//thêm vào dgv
            db.SubmitChanges();//lưu vào csdl
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            showdata();
            //reset lại các trường thuộc tính
            txttengiay.Text = txtmota.Text = txtgia.Text = txtsoluong.Text = null;
            r = null;
        }

        private void sbsua_Click(object sender, EventArgs e)
        {
            string giaText = txtgia.Text;
            string soLuongText = txtsoluong.Text;
            if (r == null)//Khong co dong nao duoc chon
            {
                MessageBox.Show("Vui Lòng chọn sản phẩm cần cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            var nv = db.SanPhams.SingleOrDefault(x => x.TenSanPham == r.Cells["TenSanPham"].Value.ToString());

            nv.TenSanPham = txttengiay.Text;
            nv.MoTa = txtmota.Text;
            // Chuyển đổi giá và số lượng sang kiểu int
            if (int.TryParse(giaText, out int gia) && int.TryParse(soLuongText, out int soLuong))
            {
                // Gán giá trị cho đối tượng NhanVien (nv)
                nv.Gia = gia;
                nv.SoLuong = soLuong;

                return; // Tiếp tục xử lý khác nếu cần
            }           
            db.SubmitChanges();
            MessageBox.Show("Cập Nhật thành công", "Thông báo", MessageBoxButtons.OK);
            showdata();
            //reset lại các trường thuộc tính
            txttengiay.Text = txtmota.Text = txtgia.Text = txtsoluong.Text = null;
            r = null;
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvSP.Rows[e.RowIndex];
                txttengiay.Text = r.Cells["TenSanPham"].Value.ToString();
                txtmota.Text = r.Cells["MoTa"].Value.ToString();
                txtgia.Text = r.Cells["Gia"].Value.ToString();
                txtsoluong.Text = r.Cells["SoLuong"].Value.ToString();

            }
        }

        private void sbxoa_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui Lòng chọn Sản phẩm cần xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (
                MessageBox.Show("bạn có thực sự muốn xóa" + r.Cells["TenSanPham"].Value.ToString() + "?", "Xác Nhận Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var nv = db.SanPhams.SingleOrDefault(x => x.TenSanPham == r.Cells["TenSanPham"].Value.ToString());
                    db.SanPhams.DeleteOnSubmit(nv);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    showdata();
                    //reset lại các trường thuộc tính
                    txttengiay.Text = txtmota.Text = txtgia.Text = txtsoluong.Text = null;
                    r = null;
                }
                catch
                {
                    MessageBox.Show("Không Thể Xóa Sản Phẩm này", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}