namespace QuanLiCuaHangGiaySABO.QlSG
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bi_nhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.bi_nhacungcap = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.bi_nhanvien,
            this.bi_nhacungcap,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1481, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bi_nhanvien
            // 
            this.bi_nhanvien.Caption = "Nhân Viên";
            this.bi_nhanvien.Id = 1;
            this.bi_nhanvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bi_nhanvien.ImageOptions.Image")));
            this.bi_nhanvien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bi_nhanvien.ImageOptions.LargeImage")));
            this.bi_nhanvien.Name = "bi_nhanvien";
            this.bi_nhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bi_nhanvien_ItemClick);
            // 
            // bi_nhacungcap
            // 
            this.bi_nhacungcap.Caption = "Nhà Cung Cấp";
            this.bi_nhacungcap.Id = 2;
            this.bi_nhacungcap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bi_nhacungcap.ImageOptions.Image")));
            this.bi_nhacungcap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bi_nhacungcap.ImageOptions.LargeImage")));
            this.bi_nhacungcap.Name = "bi_nhacungcap";
            this.bi_nhacungcap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bi_nhacungcap_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgNhanVien});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh Mục";
            // 
            // rpgNhanVien
            // 
            this.rpgNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rpgNhanVien.ImageOptions.Image")));
            this.rpgNhanVien.ItemLinks.Add(this.bi_nhanvien);
            this.rpgNhanVien.ItemLinks.Add(this.bi_nhacungcap);
            this.rpgNhanVien.ItemLinks.Add(this.barButtonItem1);
            this.rpgNhanVien.ItemLinks.Add(this.barButtonItem2);
            this.rpgNhanVien.Name = "rpgNhanVien";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 550);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1481, 30);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 580);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmTrangChu";
            this.Text = "frmTrangChu";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bi_nhanvien;
        private DevExpress.XtraBars.BarButtonItem bi_nhacungcap;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}