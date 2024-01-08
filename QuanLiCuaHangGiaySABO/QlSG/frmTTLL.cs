using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class frmTTLL : DevExpress.XtraEditors.XtraForm
    {
        public frmTTLL()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            Text = "Thông tin liên hệ";
            Size = new System.Drawing.Size(500, 200);

            var tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2
            };

            var labelAddress = new LabelControl
            {
                Text = "Địa chỉ: 180 Đường Linh Xuân, Thủ Đức, Thành Phố HCM",
                AutoSize = true,
                Appearance = { Font = new Font("Arial", 14, FontStyle.Bold) }
            };
            tableLayoutPanel.Controls.Add(labelAddress, 1, 1);

            var labelHotline = new LabelControl
            {
                Text = "Hotline: 0922223583",
                AutoSize = true,
                Appearance = { Font = new Font("Arial", 14, FontStyle.Bold) }
            };
            tableLayoutPanel.Controls.Add(labelHotline, 1, 2);

            var pictureBox = new PictureBox
            {
                Image = global::QuanLiCuaHangGiaySABO.Properties.Resources.icongiay,
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill
            };
            tableLayoutPanel.Controls.Add(pictureBox, 0, 0);
            tableLayoutPanel.SetRowSpan(pictureBox, 2);

            Controls.Add(tableLayoutPanel);
        }
    }
    }
    
    
