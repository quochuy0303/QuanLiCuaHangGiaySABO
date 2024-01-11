namespace QuanLiCuaHangGiaySABO.QlSG
{
    partial class frmbaocao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_batdau = new System.Windows.Forms.DateTimePicker();
            this.dtp_ketthuc = new System.Windows.Forms.DateTimePicker();
            this.sb_thongke = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblloinhuan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dgvdoanhthu = new System.Windows.Forms.DataGridView();
            this.dgvchiphi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltongdoanhthu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltongchiphi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoanhthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchiphi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_batdau
            // 
            this.dtp_batdau.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_batdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_batdau.Location = new System.Drawing.Point(44, 53);
            this.dtp_batdau.Name = "dtp_batdau";
            this.dtp_batdau.Size = new System.Drawing.Size(116, 23);
            this.dtp_batdau.TabIndex = 0;
            // 
            // dtp_ketthuc
            // 
            this.dtp_ketthuc.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ketthuc.Location = new System.Drawing.Point(239, 53);
            this.dtp_ketthuc.Name = "dtp_ketthuc";
            this.dtp_ketthuc.Size = new System.Drawing.Size(116, 23);
            this.dtp_ketthuc.TabIndex = 0;
            // 
            // sb_thongke
            // 
            this.sb_thongke.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.sb_thongke.Appearance.Options.UseFont = true;
            this.sb_thongke.Location = new System.Drawing.Point(1117, 28);
            this.sb_thongke.Name = "sb_thongke";
            this.sb_thongke.Size = new System.Drawing.Size(151, 62);
            this.sb_thongke.TabIndex = 1;
            this.sb_thongke.Text = "Thống Kê";
            this.sb_thongke.Click += new System.EventHandler(this.sb_thongke_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(102, 133);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(167, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Thông Kê Doanh Thu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(193, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "-->";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(534, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(271, 35);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Báo Cáo Thống Kê";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.lblloinhuan);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.dtp_batdau);
            this.panel1.Controls.Add(this.sb_thongke);
            this.panel1.Controls.Add(this.dtp_ketthuc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 111);
            this.panel1.TabIndex = 4;
            // 
            // lblloinhuan
            // 
            this.lblloinhuan.AutoSize = true;
            this.lblloinhuan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloinhuan.Location = new System.Drawing.Point(975, 71);
            this.lblloinhuan.Name = "lblloinhuan";
            this.lblloinhuan.Size = new System.Drawing.Size(28, 23);
            this.lblloinhuan.TabIndex = 4;
            this.lblloinhuan.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLiCuaHangGiaySABO.Properties.Resources.report;
            this.pictureBox1.Location = new System.Drawing.Point(493, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(868, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lợi Nhuận";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(971, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(136, 19);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Thống Kê Chi Phí";
            // 
            // dgvdoanhthu
            // 
            this.dgvdoanhthu.AllowUserToAddRows = false;
            this.dgvdoanhthu.AllowUserToDeleteRows = false;
            this.dgvdoanhthu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoanhthu.Location = new System.Drawing.Point(12, 182);
            this.dgvdoanhthu.Name = "dgvdoanhthu";
            this.dgvdoanhthu.ReadOnly = true;
            this.dgvdoanhthu.RowHeadersWidth = 51;
            this.dgvdoanhthu.RowTemplate.Height = 24;
            this.dgvdoanhthu.Size = new System.Drawing.Size(652, 340);
            this.dgvdoanhthu.TabIndex = 5;
            // 
            // dgvchiphi
            // 
            this.dgvchiphi.AllowUserToAddRows = false;
            this.dgvchiphi.AllowUserToDeleteRows = false;
            this.dgvchiphi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvchiphi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchiphi.Location = new System.Drawing.Point(706, 182);
            this.dgvchiphi.Name = "dgvchiphi";
            this.dgvchiphi.ReadOnly = true;
            this.dgvchiphi.RowHeadersWidth = 51;
            this.dgvchiphi.RowTemplate.Height = 24;
            this.dgvchiphi.Size = new System.Drawing.Size(639, 340);
            this.dgvchiphi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng Doanh Thu";
            // 
            // lbltongdoanhthu
            // 
            this.lbltongdoanhthu.AutoSize = true;
            this.lbltongdoanhthu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongdoanhthu.Location = new System.Drawing.Point(220, 580);
            this.lbltongdoanhthu.Name = "lbltongdoanhthu";
            this.lbltongdoanhthu.Size = new System.Drawing.Size(24, 19);
            this.lbltongdoanhthu.TabIndex = 4;
            this.lbltongdoanhthu.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(906, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng Chi Phí";
            // 
            // lbltongchiphi
            // 
            this.lbltongchiphi.AutoSize = true;
            this.lbltongchiphi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongchiphi.Location = new System.Drawing.Point(1062, 580);
            this.lbltongchiphi.Name = "lbltongchiphi";
            this.lbltongchiphi.Size = new System.Drawing.Size(24, 19);
            this.lbltongchiphi.TabIndex = 4;
            this.lbltongchiphi.Text = "...";
            // 
            // frmbaocao
            // 
            this.Appearance.BackColor = System.Drawing.Color.Thistle;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 643);
            this.Controls.Add(this.lbltongchiphi);
            this.Controls.Add(this.lbltongdoanhthu);
            this.Controls.Add(this.dgvchiphi);
            this.Controls.Add(this.dgvdoanhthu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmbaocao";
            this.Text = "frmbaocao";
            this.Load += new System.EventHandler(this.frmbaocao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoanhthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchiphi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_batdau;
        private System.Windows.Forms.DateTimePicker dtp_ketthuc;
        private DevExpress.XtraEditors.SimpleButton sb_thongke;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblloinhuan;
        private System.Windows.Forms.DataGridView dgvdoanhthu;
        private System.Windows.Forms.DataGridView dgvchiphi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltongdoanhthu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltongchiphi;
    }
}