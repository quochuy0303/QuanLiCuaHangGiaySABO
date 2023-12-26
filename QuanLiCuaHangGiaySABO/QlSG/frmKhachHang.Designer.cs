namespace QuanLiCuaHangGiaySABO.QlSG
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthotenkh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtlockh = new System.Windows.Forms.TextBox();
            this.txttimkh = new System.Windows.Forms.TextBox();
            this.sbtimkiemkh = new DevExpress.XtraEditors.SimpleButton();
            this.sblockh = new DevExpress.XtraEditors.SimpleButton();
            this.sbxoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbsua = new DevExpress.XtraEditors.SimpleButton();
            this.sbthem = new DevExpress.XtraEditors.SimpleButton();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtdiachi);
            this.groupControl1.Controls.Add(this.txtemail);
            this.groupControl1.Controls.Add(this.txtsdt);
            this.groupControl1.Controls.Add(this.txthotenkh);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(31, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(593, 279);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông Tin Khách Hàng";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(167, 167);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(271, 25);
            this.txtdiachi.TabIndex = 1;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(170, 116);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(271, 23);
            this.txtemail.TabIndex = 1;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(170, 221);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(239, 23);
            this.txtsdt.TabIndex = 1;
            this.txtsdt.TextChanged += new System.EventHandler(this.txtsdt_TextChanged);
            // 
            // txthotenkh
            // 
            this.txthotenkh.Location = new System.Drawing.Point(170, 60);
            this.txthotenkh.Name = "txthotenkh";
            this.txthotenkh.Size = new System.Drawing.Size(235, 23);
            this.txthotenkh.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "SĐT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
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
            this.groupControl2.Location = new System.Drawing.Point(643, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(578, 279);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Chức Năng";
            // 
            // txtlockh
            // 
            this.txtlockh.Location = new System.Drawing.Point(411, 142);
            this.txtlockh.Name = "txtlockh";
            this.txtlockh.Size = new System.Drawing.Size(144, 23);
            this.txtlockh.TabIndex = 2;
            // 
            // txttimkh
            // 
            this.txttimkh.Location = new System.Drawing.Point(411, 88);
            this.txttimkh.Name = "txttimkh";
            this.txttimkh.Size = new System.Drawing.Size(144, 23);
            this.txttimkh.TabIndex = 2;
            this.txttimkh.TextChanged += new System.EventHandler(this.txttimkh_TextChanged);
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
            this.sbtimkiemkh.Click += new System.EventHandler(this.sbtimkiem_Click);
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
            this.sblockh.Click += new System.EventHandler(this.sblockh_Click);
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
            // dgvKH
            // 
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.AllowUserToDeleteRows = false;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKH.Location = new System.Drawing.Point(0, 320);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(1357, 202);
            this.dgvKH.TabIndex = 5;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 522);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthotenkh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton sbtimkiemkh;
        private DevExpress.XtraEditors.SimpleButton sblockh;
        private DevExpress.XtraEditors.SimpleButton sbxoa;
        private DevExpress.XtraEditors.SimpleButton sbsua;
        private DevExpress.XtraEditors.SimpleButton sbthem;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.TextBox txtlockh;
        private System.Windows.Forms.TextBox txttimkh;
    }
}