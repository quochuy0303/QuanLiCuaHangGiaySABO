namespace QuanLiCuaHangGiaySABO.QlSG
{
    partial class frmForgotPassword
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtemail = new DevExpress.XtraEditors.TextEdit();
            this.sb_xacnhan = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtnewpass = new DevExpress.XtraEditors.TextEdit();
            this.txtcomfirm = new DevExpress.XtraEditors.TextEdit();
            this.sp_OTP = new DevExpress.XtraEditors.SimpleButton();
            this.txtOTP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnewpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcomfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(68, 434);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(318, 76);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Ghi Chú:\r\nMã OTP sẽ được gửi vào email của bạn\r\n\r\n\r\n";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(277, 96);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Properties.Appearance.Options.UseFont = true;
            this.txtemail.Size = new System.Drawing.Size(245, 26);
            this.txtemail.TabIndex = 9;
            // 
            // sb_xacnhan
            // 
            this.sb_xacnhan.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_xacnhan.Appearance.Options.UseFont = true;
            this.sb_xacnhan.Location = new System.Drawing.Point(266, 349);
            this.sb_xacnhan.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.sb_xacnhan.Name = "sb_xacnhan";
            this.sb_xacnhan.Size = new System.Drawing.Size(154, 50);
            this.sb_xacnhan.TabIndex = 7;
            this.sb_xacnhan.Text = "xác nhận";
            this.sb_xacnhan.Click += new System.EventHandler(this.sb_xacnhan_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(68, 99);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 19);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Nhập email ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(60, 161);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(107, 19);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Mật Khẩu Mới";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(60, 222);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(193, 19);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Xác Nhận Mật Khẩu Mới";
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(277, 158);
            this.txtnewpass.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpass.Properties.Appearance.Options.UseFont = true;
            this.txtnewpass.Size = new System.Drawing.Size(159, 26);
            this.txtnewpass.TabIndex = 9;
            this.txtnewpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnewpass_KeyPress);
            // 
            // txtcomfirm
            // 
            this.txtcomfirm.Location = new System.Drawing.Point(277, 219);
            this.txtcomfirm.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtcomfirm.Name = "txtcomfirm";
            this.txtcomfirm.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomfirm.Properties.Appearance.Options.UseFont = true;
            this.txtcomfirm.Size = new System.Drawing.Size(159, 26);
            this.txtcomfirm.TabIndex = 8;
            this.txtcomfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcomfirm_KeyPress);
            // 
            // sp_OTP
            // 
            this.sp_OTP.Location = new System.Drawing.Point(484, 275);
            this.sp_OTP.Margin = new System.Windows.Forms.Padding(4);
            this.sp_OTP.Name = "sp_OTP";
            this.sp_OTP.Size = new System.Drawing.Size(88, 28);
            this.sp_OTP.TabIndex = 14;
            this.sp_OTP.Text = "Gửi OTP";
            this.sp_OTP.Click += new System.EventHandler(this.sp_OTP_Click);
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(277, 277);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.Properties.Appearance.Options.UseFont = true;
            this.txtOTP.Size = new System.Drawing.Size(143, 26);
            this.txtOTP.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(68, 275);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 19);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Nhập OTP";
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 512);
            this.Controls.Add(this.sp_OTP);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtcomfirm);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.sb_xacnhan);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmForgotPassword";
            this.Text = "frmForgotPassword";
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnewpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcomfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOTP.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtemail;
        private DevExpress.XtraEditors.SimpleButton sb_xacnhan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtnewpass;
        private DevExpress.XtraEditors.TextEdit txtcomfirm;
        private DevExpress.XtraEditors.SimpleButton sp_OTP;
        private DevExpress.XtraEditors.TextEdit txtOTP;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}