﻿namespace QuanLiCuaHangGiaySABO.QlSG
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.sbtimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.sbloc = new DevExpress.XtraEditors.SimpleButton();
            this.sbxoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbsua = new DevExpress.XtraEditors.SimpleButton();
            this.sbthem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.txtTimKiemNCC = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNCC
            // 
            this.dgvNCC.AllowUserToAddRows = false;
            this.dgvNCC.AllowUserToDeleteRows = false;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNCC.Location = new System.Drawing.Point(0, 278);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.ReadOnly = true;
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.Size = new System.Drawing.Size(1262, 268);
            this.dgvNCC.TabIndex = 4;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // sbtimkiem
            // 
            this.sbtimkiem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtimkiem.Appearance.Options.UseFont = true;
            this.sbtimkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtimkiem.ImageOptions.Image")));
            this.sbtimkiem.Location = new System.Drawing.Point(242, 52);
            this.sbtimkiem.Name = "sbtimkiem";
            this.sbtimkiem.Size = new System.Drawing.Size(120, 33);
            this.sbtimkiem.TabIndex = 0;
            this.sbtimkiem.Text = "Tìm Kiếm";
            this.sbtimkiem.Click += new System.EventHandler(this.sbtimkiem_Click);
            // 
            // sbloc
            // 
            this.sbloc.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbloc.Appearance.Options.UseFont = true;
            this.sbloc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbloc.ImageOptions.Image")));
            this.sbloc.Location = new System.Drawing.Point(242, 113);
            this.sbloc.Name = "sbloc";
            this.sbloc.Size = new System.Drawing.Size(120, 33);
            this.sbloc.TabIndex = 0;
            this.sbloc.Text = "Lọc";
            this.sbloc.Click += new System.EventHandler(this.sbloc_Click);
            // 
            // sbxoa
            // 
            this.sbxoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbxoa.Appearance.Options.UseFont = true;
            this.sbxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbxoa.ImageOptions.Image")));
            this.sbxoa.Location = new System.Drawing.Point(68, 113);
            this.sbxoa.Name = "sbxoa";
            this.sbxoa.Size = new System.Drawing.Size(120, 33);
            this.sbxoa.TabIndex = 0;
            this.sbxoa.Text = "Xóa";
            this.sbxoa.Click += new System.EventHandler(this.sbxoa_Click);
            // 
            // sbsua
            // 
            this.sbsua.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbsua.Appearance.Options.UseFont = true;
            this.sbsua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbsua.ImageOptions.Image")));
            this.sbsua.Location = new System.Drawing.Point(68, 173);
            this.sbsua.Name = "sbsua";
            this.sbsua.Size = new System.Drawing.Size(120, 33);
            this.sbsua.TabIndex = 0;
            this.sbsua.Text = "Sửa";
            this.sbsua.Click += new System.EventHandler(this.sbsua_Click);
            // 
            // sbthem
            // 
            this.sbthem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbthem.Appearance.Options.UseFont = true;
            this.sbthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbthem.ImageOptions.Image")));
            this.sbthem.Location = new System.Drawing.Point(68, 52);
            this.sbthem.Name = "sbthem";
            this.sbthem.Size = new System.Drawing.Size(120, 33);
            this.sbthem.TabIndex = 0;
            this.sbthem.Text = "Thêm";
            this.sbthem.Click += new System.EventHandler(this.sbthem_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.sbtimkiem);
            this.groupControl2.Controls.Add(this.sbloc);
            this.groupControl2.Controls.Add(this.sbxoa);
            this.groupControl2.Controls.Add(this.txtLoc);
            this.groupControl2.Controls.Add(this.txtTimKiemNCC);
            this.groupControl2.Controls.Add(this.sbsua);
            this.groupControl2.Controls.Add(this.sbthem);
            this.groupControl2.Location = new System.Drawing.Point(571, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(578, 235);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Chức Năng";
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(382, 120);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(160, 23);
            this.txtLoc.TabIndex = 1;
            this.txtLoc.TextChanged += new System.EventHandler(this.txtLoc_TextChanged);
            // 
            // txtTimKiemNCC
            // 
            this.txtTimKiemNCC.Location = new System.Drawing.Point(382, 59);
            this.txtTimKiemNCC.Name = "txtTimKiemNCC";
            this.txtTimKiemNCC.Size = new System.Drawing.Size(160, 23);
            this.txtTimKiemNCC.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtdiachi);
            this.groupControl1.Controls.Add(this.txtsdt);
            this.groupControl1.Controls.Add(this.txthoten);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(37, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(528, 235);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(196, 164);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(310, 25);
            this.txtdiachi.TabIndex = 1;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(196, 109);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(109, 23);
            this.txtsdt.TabIndex = 1;
            this.txtsdt.TextChanged += new System.EventHandler(this.txtsdt_TextChanged);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(196, 59);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(205, 23);
            this.txthoten.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "SĐT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhà Cung Cấp";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::QuanLiCuaHangGiaySABO.Properties.Resources.arrow;
            this.pictureEdit1.Location = new System.Drawing.Point(1179, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(43, 42);
            this.pictureEdit1.TabIndex = 7;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 546);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.groupControl2);
            this.Name = "frmNhaCungCap";
            this.Text = "frmNhaCungCap";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNCC;
        private DevExpress.XtraEditors.SimpleButton sbtimkiem;
        private DevExpress.XtraEditors.SimpleButton sbloc;
        private DevExpress.XtraEditors.SimpleButton sbxoa;
        private DevExpress.XtraEditors.SimpleButton sbsua;
        private DevExpress.XtraEditors.SimpleButton sbthem;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.TextBox txtTimKiemNCC;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}