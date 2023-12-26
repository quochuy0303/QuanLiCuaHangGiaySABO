namespace QuanLiCuaHangGiaySABO.QlSG
{
    partial class frmQuyenHan
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
            this.dgvQH = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQH
            // 
            this.dgvQH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQH.Location = new System.Drawing.Point(0, 282);
            this.dgvQH.Name = "dgvQH";
            this.dgvQH.RowHeadersWidth = 51;
            this.dgvQH.RowTemplate.Height = 24;
            this.dgvQH.Size = new System.Drawing.Size(869, 256);
            this.dgvQH.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(310, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(213, 47);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Quyền Hạn";
            // 
            // frmQuyenHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 538);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dgvQH);
            this.Name = "frmQuyenHan";
            this.Text = "frmQuyenHan";
            this.Load += new System.EventHandler(this.frmQuyenHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQH;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}