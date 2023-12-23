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
            
        }
    }
}
