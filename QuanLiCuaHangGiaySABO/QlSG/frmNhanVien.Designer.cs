﻿namespace QuanLiCuaHangGiaySABO
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.sbtimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.sbloc = new DevExpress.XtraEditors.SimpleButton();
            this.txtloc = new System.Windows.Forms.TextBox();
            this.sbxoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbsua = new DevExpress.XtraEditors.SimpleButton();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.sbthem = new DevExpress.XtraEditors.SimpleButton();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtdiachi);
            this.groupControl1.Controls.Add(this.txtsdt);
            this.groupControl1.Controls.Add(this.txtemail);
            this.groupControl1.Controls.Add(this.txtchucvu);
            this.groupControl1.Controls.Add(this.txthoten);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(12, 14);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(534, 279);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Nhân Viên";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(124, 88);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(271, 25);
            this.txtdiachi.TabIndex = 1;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(124, 141);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(109, 23);
            this.txtsdt.TabIndex = 1;
            this.txtsdt.TextChanged += new System.EventHandler(this.txtsdt_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(124, 236);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(309, 23);
            this.txtemail.TabIndex = 1;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Enabled = false;
            this.txtchucvu.Location = new System.Drawing.Point(124, 190);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(130, 23);
            this.txtchucvu.TabIndex = 1;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(127, 44);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(235, 23);
            this.txthoten.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.pictureEdit1);
            this.groupControl2.Controls.Add(this.sbtimkiem);
            this.groupControl2.Controls.Add(this.sbloc);
            this.groupControl2.Controls.Add(this.txtloc);
            this.groupControl2.Controls.Add(this.sbxoa);
            this.groupControl2.Controls.Add(this.sbsua);
            this.groupControl2.Controls.Add(this.txttimkiem);
            this.groupControl2.Controls.Add(this.sbthem);
            this.groupControl2.Location = new System.Drawing.Point(12, 299);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(534, 259);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Chức Năng";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::QuanLiCuaHangGiaySABO.Properties.Resources.arrow;
            this.pictureEdit1.Location = new System.Drawing.Point(235, 157);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(43, 42);
            this.pictureEdit1.TabIndex = 6;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // sbtimkiem
            // 
            this.sbtimkiem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtimkiem.Appearance.Options.UseFont = true;
            this.sbtimkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtimkiem.ImageOptions.Image")));
            this.sbtimkiem.Location = new System.Drawing.Point(211, 45);
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
            this.sbloc.Location = new System.Drawing.Point(211, 106);
            this.sbloc.Name = "sbloc";
            this.sbloc.Size = new System.Drawing.Size(120, 33);
            this.sbloc.TabIndex = 0;
            this.sbloc.Text = "Lọc";
            this.sbloc.Click += new System.EventHandler(this.sbloc_Click);
            // 
            // txtloc
            // 
            this.txtloc.Location = new System.Drawing.Point(337, 113);
            this.txtloc.Name = "txtloc";
            this.txtloc.Size = new System.Drawing.Size(172, 23);
            this.txtloc.TabIndex = 1;
            // 
            // sbxoa
            // 
            this.sbxoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbxoa.Appearance.Options.UseFont = true;
            this.sbxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbxoa.ImageOptions.Image")));
            this.sbxoa.Location = new System.Drawing.Point(37, 106);
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
            this.sbsua.Location = new System.Drawing.Point(37, 166);
            this.sbsua.Name = "sbsua";
            this.sbsua.Size = new System.Drawing.Size(120, 33);
            this.sbsua.TabIndex = 0;
            this.sbsua.Text = "Sửa";
            this.sbsua.Click += new System.EventHandler(this.sbsua_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(337, 52);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(172, 23);
            this.txttimkiem.TabIndex = 1;
            // 
            // sbthem
            // 
            this.sbthem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbthem.Appearance.Options.UseFont = true;
            this.sbthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbthem.ImageOptions.Image")));
            this.sbthem.Location = new System.Drawing.Point(37, 45);
            this.sbthem.Name = "sbthem";
            this.sbthem.Size = new System.Drawing.Size(120, 33);
            this.sbthem.TabIndex = 0;
            this.sbthem.Text = "Thêm";
            this.sbthem.Click += new System.EventHandler(this.sbthem_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvNhanVien.Location = new System.Drawing.Point(621, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(873, 574);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // frmNhanVien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::QuanLiCuaHangGiaySABO.Properties.Resources.poster_giay_dep_mat;
            this.ClientSize = new System.Drawing.Size(1494, 574);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmNhanVien.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.TextChanged += new System.EventHandler(this.frmNhanVien_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton sbtimkiem;
        private DevExpress.XtraEditors.SimpleButton sbloc;
        private DevExpress.XtraEditors.SimpleButton sbxoa;
        private DevExpress.XtraEditors.SimpleButton sbsua;
        private DevExpress.XtraEditors.SimpleButton sbthem;
        private System.Windows.Forms.TextBox txtloc;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}

