namespace QuanLiCuaHangGiaySABO.QlSG
{
    partial class frmLogin
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sb_sign = new DevExpress.XtraEditors.SimpleButton();
            this.te_password = new DevExpress.XtraEditors.TextEdit();
            this.te_username = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sb_login = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.hpl_fogotpass = new DevExpress.XtraEditors.HyperLinkEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ce_ShowPassword = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.te_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpl_fogotpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_ShowPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(461, 279);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tài Khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(461, 333);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật Khẩu";
            // 
            // sb_sign
            // 
            this.sb_sign.Appearance.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_sign.Appearance.Options.UseFont = true;
            this.sb_sign.Location = new System.Drawing.Point(671, 370);
            this.sb_sign.Name = "sb_sign";
            this.sb_sign.Size = new System.Drawing.Size(125, 49);
            this.sb_sign.TabIndex = 4;
            this.sb_sign.Text = "Đăng Kí";
            this.sb_sign.Click += new System.EventHandler(this.sb_sign_Click);
            // 
            // te_password
            // 
            this.te_password.Location = new System.Drawing.Point(554, 327);
            this.te_password.Name = "te_password";
            this.te_password.Size = new System.Drawing.Size(197, 22);
            this.te_password.TabIndex = 2;
            // 
            // te_username
            // 
            this.te_username.Location = new System.Drawing.Point(554, 275);
            this.te_username.Name = "te_username";
            this.te_username.Size = new System.Drawing.Size(197, 22);
            this.te_username.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.ContentImage = global::QuanLiCuaHangGiaySABO.Properties.Resources.stock_vector_shoes_shop_logo_template_design_1680762358;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(320, 529);
            this.panelControl1.TabIndex = 0;
            // 
            // sb_login
            // 
            this.sb_login.Appearance.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_login.Appearance.Options.UseFont = true;
            this.sb_login.Location = new System.Drawing.Point(461, 370);
            this.sb_login.Name = "sb_login";
            this.sb_login.Size = new System.Drawing.Size(125, 49);
            this.sb_login.TabIndex = 4;
            this.sb_login.Text = "Đăng Nhập";
            this.sb_login.Click += new System.EventHandler(this.sb_login_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(538, 152);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(162, 68);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "LOGIN";
            // 
            // hpl_fogotpass
            // 
            this.hpl_fogotpass.EditValue = "Quên mật khẩu ?";
            this.hpl_fogotpass.Location = new System.Drawing.Point(554, 458);
            this.hpl_fogotpass.Name = "hpl_fogotpass";
            this.hpl_fogotpass.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hpl_fogotpass.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpl_fogotpass.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.hpl_fogotpass.Properties.Appearance.Options.UseBackColor = true;
            this.hpl_fogotpass.Properties.Appearance.Options.UseFont = true;
            this.hpl_fogotpass.Properties.Appearance.Options.UseForeColor = true;
            this.hpl_fogotpass.Size = new System.Drawing.Size(146, 24);
            this.hpl_fogotpass.TabIndex = 7;
            this.hpl_fogotpass.OpenLink += new DevExpress.XtraEditors.Controls.OpenLinkEventHandler(this.hpl_fogotpass_OpenLink);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(178)))), ((int)(((byte)(63)))));
            this.panel1.BackgroundImage = global::QuanLiCuaHangGiaySABO.Properties.Resources.user;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(569, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 118);
            this.panel1.TabIndex = 8;
            // 
            // ce_ShowPassword
            // 
            this.ce_ShowPassword.Location = new System.Drawing.Point(757, 327);
            this.ce_ShowPassword.Name = "ce_ShowPassword";
            this.ce_ShowPassword.Properties.Appearance.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.ce_ShowPassword.Properties.Appearance.Options.UseFont = true;
            this.ce_ShowPassword.Properties.Caption = "Ẩn/Hiện";
            this.ce_ShowPassword.Size = new System.Drawing.Size(107, 24);
            this.ce_ShowPassword.TabIndex = 9;
            this.ce_ShowPassword.CheckedChanged += new System.EventHandler(this.ce_ShowPassword_CheckedChanged);
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::QuanLiCuaHangGiaySABO.Properties.Resources.istockphoto_1434341714_612x612;
            this.ClientSize = new System.Drawing.Size(897, 529);
            this.Controls.Add(this.ce_ShowPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hpl_fogotpass);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.sb_login);
            this.Controls.Add(this.sb_sign);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.te_password);
            this.Controls.Add(this.te_username);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = global::QuanLiCuaHangGiaySABO.Properties.Resources._295128;
            this.Name = "frmLogin";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.te_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpl_fogotpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_ShowPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit te_username;
        private DevExpress.XtraEditors.TextEdit te_password;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sb_sign;
        private DevExpress.XtraEditors.SimpleButton sb_login;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.HyperLinkEdit hpl_fogotpass;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.CheckEdit ce_ShowPassword;
    }
}