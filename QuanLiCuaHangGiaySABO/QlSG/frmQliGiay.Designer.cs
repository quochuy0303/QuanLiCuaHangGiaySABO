namespace QuanLiCuaHangGiaySABO.QlSG
{
    partial class frmQliGiay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQliGiay));
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txttengiay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sbtimkiemkh = new DevExpress.XtraEditors.SimpleButton();
            this.sblockh = new DevExpress.XtraEditors.SimpleButton();
            this.sbxoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbsua = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlockh = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txttimkh = new System.Windows.Forms.TextBox();
            this.sbthem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSP
            // 
            this.dgvSP.AllowUserToAddRows = false;
            this.dgvSP.AllowUserToDeleteRows = false;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSP.Location = new System.Drawing.Point(0, 341);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.ReadOnly = true;
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.RowTemplate.Height = 24;
            this.dgvSP.Size = new System.Drawing.Size(1371, 202);
            this.dgvSP.TabIndex = 8;
            this.dgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellClick);
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(170, 139);
            this.txtgia.Multiline = true;
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(132, 25);
            this.txtgia.TabIndex = 1;
            this.txtgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgia_KeyPress);
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(173, 96);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(288, 23);
            this.txtmota.TabIndex = 1;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(173, 193);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(108, 23);
            this.txtsoluong.TabIndex = 1;
            // 
            // txttengiay
            // 
            this.txttengiay.Location = new System.Drawing.Point(173, 45);
            this.txttengiay.Name = "txttengiay";
            this.txttengiay.Size = new System.Drawing.Size(288, 23);
            this.txttengiay.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô Tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng tồn";
            // 
            // sbtimkiemkh
            // 
            this.sbtimkiemkh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtimkiemkh.Appearance.Options.UseFont = true;
            this.sbtimkiemkh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtimkiemkh.ImageOptions.Image")));
            this.sbtimkiemkh.Location = new System.Drawing.Point(263, 81);
            this.sbtimkiemkh.Name = "sbtimkiemkh";
            this.sbtimkiemkh.Size = new System.Drawing.Size(120, 33);
            this.sbtimkiemkh.TabIndex = 0;
            this.sbtimkiemkh.Text = "Tìm Kiếm";
            // 
            // sblockh
            // 
            this.sblockh.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sblockh.Appearance.Options.UseFont = true;
            this.sblockh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sblockh.ImageOptions.Image")));
            this.sblockh.Location = new System.Drawing.Point(263, 142);
            this.sblockh.Name = "sblockh";
            this.sblockh.Size = new System.Drawing.Size(120, 33);
            this.sblockh.TabIndex = 0;
            this.sblockh.Text = "Lọc";
            // 
            // sbxoa
            // 
            this.sbxoa.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbxoa.Appearance.Options.UseFont = true;
            this.sbxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbxoa.ImageOptions.Image")));
            this.sbxoa.Location = new System.Drawing.Point(89, 142);
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
            this.sbsua.Location = new System.Drawing.Point(89, 202);
            this.sbsua.Name = "sbsua";
            this.sbsua.Size = new System.Drawing.Size(120, 33);
            this.sbsua.TabIndex = 0;
            this.sbsua.Text = "Sửa";
            this.sbsua.Click += new System.EventHandler(this.sbsua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Giày";
            // 
            // txtlockh
            // 
            this.txtlockh.Location = new System.Drawing.Point(411, 142);
            this.txtlockh.Name = "txtlockh";
            this.txtlockh.Size = new System.Drawing.Size(144, 23);
            this.txtlockh.TabIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtlockh);
            this.groupControl2.Controls.Add(this.txttimkh);
            this.groupControl2.Controls.Add(this.sbtimkiemkh);
            this.groupControl2.Controls.Add(this.sblockh);
            this.groupControl2.Controls.Add(this.sbxoa);
            this.groupControl2.Controls.Add(this.sbsua);
            this.groupControl2.Controls.Add(this.sbthem);
            this.groupControl2.Location = new System.Drawing.Point(660, 6);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(578, 279);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Chức Năng";
            // 
            // txttimkh
            // 
            this.txttimkh.Location = new System.Drawing.Point(411, 88);
            this.txttimkh.Name = "txttimkh";
            this.txttimkh.Size = new System.Drawing.Size(144, 23);
            this.txttimkh.TabIndex = 2;
            // 
            // sbthem
            // 
            this.sbthem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbthem.Appearance.Options.UseFont = true;
            this.sbthem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbthem.ImageOptions.Image")));
            this.sbthem.Location = new System.Drawing.Point(89, 81);
            this.sbthem.Name = "sbthem";
            this.sbthem.Size = new System.Drawing.Size(120, 33);
            this.sbthem.TabIndex = 0;
            this.sbthem.Text = "Thêm";
            this.sbthem.Click += new System.EventHandler(this.sbthem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtgia);
            this.groupControl1.Controls.Add(this.txtmota);
            this.groupControl1.Controls.Add(this.txtsoluong);
            this.groupControl1.Controls.Add(this.txttengiay);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(31, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(593, 279);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = " Thông Tin Sản Phẩm ";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::QuanLiCuaHangGiaySABO.Properties.Resources.arrow;
            this.pictureEdit1.Location = new System.Drawing.Point(1266, 32);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(43, 42);
            this.pictureEdit1.TabIndex = 9;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // frmQliGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 543);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.dgvSP);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmQliGiay";
            this.Text = "frmQliGiay";
            this.Load += new System.EventHandler(this.frmQliGiay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
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

        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txttengiay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton sbtimkiemkh;
        private DevExpress.XtraEditors.SimpleButton sblockh;
        private DevExpress.XtraEditors.SimpleButton sbxoa;
        private DevExpress.XtraEditors.SimpleButton sbsua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlockh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txttimkh;
        private DevExpress.XtraEditors.SimpleButton sbthem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}