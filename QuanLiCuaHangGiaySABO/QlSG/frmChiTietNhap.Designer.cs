namespace QuanLiCuaHangGiaySABO.QlSG
{
    partial class frmChiTietNhap
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
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.rbtnhapkho = new System.Windows.Forms.RadioButton();
            this.rbtyeucau = new System.Windows.Forms.RadioButton();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txttienthanhtoan = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbmathang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvchitiethoadon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiethoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxacnhan.Location = new System.Drawing.Point(1179, 462);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(119, 46);
            this.btnxacnhan.TabIndex = 40;
            this.btnxacnhan.Text = "Xác Nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // rbtnhapkho
            // 
            this.rbtnhapkho.AutoSize = true;
            this.rbtnhapkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnhapkho.Location = new System.Drawing.Point(693, 475);
            this.rbtnhapkho.Name = "rbtnhapkho";
            this.rbtnhapkho.Size = new System.Drawing.Size(108, 24);
            this.rbtnhapkho.TabIndex = 38;
            this.rbtnhapkho.Text = "Nhập kho";
            this.rbtnhapkho.UseVisualStyleBackColor = true;
            this.rbtnhapkho.CheckedChanged += new System.EventHandler(this.rbtnhapkho_CheckedChanged);
            this.rbtnhapkho.Click += new System.EventHandler(this.rbtnhapkho_Click);
            // 
            // rbtyeucau
            // 
            this.rbtyeucau.AutoSize = true;
            this.rbtyeucau.Checked = true;
            this.rbtyeucau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtyeucau.Location = new System.Drawing.Point(555, 477);
            this.rbtyeucau.Name = "rbtyeucau";
            this.rbtyeucau.Size = new System.Drawing.Size(100, 24);
            this.rbtyeucau.TabIndex = 39;
            this.rbtyeucau.TabStop = true;
            this.rbtyeucau.Text = "Yêu Cầu";
            this.rbtyeucau.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(218, 445);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(86, 37);
            this.btnxoa.TabIndex = 37;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(61, 445);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 37);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(112, 165);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 23);
            this.txtSL.TabIndex = 33;
            // 
            // txttienthanhtoan
            // 
            this.txttienthanhtoan.Location = new System.Drawing.Point(1034, 475);
            this.txttienthanhtoan.Name = "txttienthanhtoan";
            this.txttienthanhtoan.Size = new System.Drawing.Size(129, 23);
            this.txttienthanhtoan.TabIndex = 34;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(112, 112);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(100, 23);
            this.txtdongia.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Số Lượng:";
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongtien.Location = new System.Drawing.Point(24, 251);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(24, 20);
            this.lbltongtien.TabIndex = 30;
            this.lbltongtien.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(860, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tiền Thanh Toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Đơn Gía";
            // 
            // cbbmathang
            // 
            this.cbbmathang.FormattingEnabled = true;
            this.cbbmathang.Location = new System.Drawing.Point(112, 61);
            this.cbbmathang.Name = "cbbmathang";
            this.cbbmathang.Size = new System.Drawing.Size(241, 24);
            this.cbbmathang.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mặt Hàng";
            // 
            // dgvchitiethoadon
            // 
            this.dgvchitiethoadon.AllowUserToAddRows = false;
            this.dgvchitiethoadon.AllowUserToDeleteRows = false;
            this.dgvchitiethoadon.AllowUserToOrderColumns = true;
            this.dgvchitiethoadon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvchitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchitiethoadon.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvchitiethoadon.Location = new System.Drawing.Point(397, 25);
            this.dgvchitiethoadon.Name = "dgvchitiethoadon";
            this.dgvchitiethoadon.ReadOnly = true;
            this.dgvchitiethoadon.RowHeadersWidth = 51;
            this.dgvchitiethoadon.RowTemplate.Height = 24;
            this.dgvchitiethoadon.Size = new System.Drawing.Size(901, 408);
            this.dgvchitiethoadon.TabIndex = 26;
            this.dgvchitiethoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchitiethoadon_CellClick);
            // 
            // frmChiTietNhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 551);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.rbtnhapkho);
            this.Controls.Add(this.rbtyeucau);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txttienthanhtoan);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltongtien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbmathang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvchitiethoadon);
            this.Name = "frmChiTietNhap";
            this.Text = "frmChiTietNhap";
            this.Load += new System.EventHandler(this.frmChiTietNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchitiethoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.RadioButton rbtnhapkho;
        private System.Windows.Forms.RadioButton rbtyeucau;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txttienthanhtoan;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbmathang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvchitiethoadon;
    }
}