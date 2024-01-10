namespace QuanLiCuaHangGiaySABO.QlSG
{
    partial class frmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            this.txttimkh = new System.Windows.Forms.TextBox();
            this.sbtimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.sbnhaphang = new DevExpress.XtraEditors.SimpleButton();
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txttimkh
            // 
            this.txttimkh.Location = new System.Drawing.Point(138, 19);
            this.txttimkh.Name = "txttimkh";
            this.txttimkh.Size = new System.Drawing.Size(238, 23);
            this.txttimkh.TabIndex = 2;
            // 
            // sbtimkiem
            // 
            this.sbtimkiem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbtimkiem.Appearance.Options.UseFont = true;
            this.sbtimkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtimkiem.ImageOptions.Image")));
            this.sbtimkiem.Location = new System.Drawing.Point(12, 12);
            this.sbtimkiem.Name = "sbtimkiem";
            this.sbtimkiem.Size = new System.Drawing.Size(120, 33);
            this.sbtimkiem.TabIndex = 0;
            this.sbtimkiem.Text = "Tìm Kiếm";
            // 
            // sbnhaphang
            // 
            this.sbnhaphang.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbnhaphang.Appearance.Options.UseFont = true;
            this.sbnhaphang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbnhaphang.ImageOptions.Image")));
            this.sbnhaphang.Location = new System.Drawing.Point(12, 76);
            this.sbnhaphang.Name = "sbnhaphang";
            this.sbnhaphang.Size = new System.Drawing.Size(132, 33);
            this.sbnhaphang.TabIndex = 0;
            this.sbnhaphang.Text = "Nhập Hàng";
            this.sbnhaphang.Click += new System.EventHandler(this.sbnhaphang_Click);
            // 
            // dgvKho
            // 
            this.dgvKho.AllowUserToAddRows = false;
            this.dgvKho.AllowUserToDeleteRows = false;
            this.dgvKho.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvKho.Location = new System.Drawing.Point(457, 0);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.ReadOnly = true;
            this.dgvKho.RowHeadersWidth = 51;
            this.dgvKho.RowTemplate.Height = 24;
            this.dgvKho.Size = new System.Drawing.Size(900, 547);
            this.dgvKho.TabIndex = 11;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureEdit1.EditValue = global::QuanLiCuaHangGiaySABO.Properties.Resources.arrow;
            this.pictureEdit1.Location = new System.Drawing.Point(408, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(43, 42);
            this.pictureEdit1.TabIndex = 12;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // frmKho
            // 
            this.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 547);
            this.Controls.Add(this.txttimkh);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.sbtimkiem);
            this.Controls.Add(this.sbnhaphang);
            this.Controls.Add(this.dgvKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKho";
            this.Text = "frmKho";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txttimkh;
        private DevExpress.XtraEditors.SimpleButton sbtimkiem;
        private DevExpress.XtraEditors.SimpleButton sbnhaphang;
        private System.Windows.Forms.DataGridView dgvKho;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}