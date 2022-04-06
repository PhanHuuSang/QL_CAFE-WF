
namespace QL_CAFE
{
    partial class frmInHoaDon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInHoaDon));
            this.CHITIETHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHD = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CHITIETHOADONBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CHITIETHOADONBindingSource
            // 
            this.CHITIETHOADONBindingSource.DataSource = typeof(QL_CAFE.Models.CHITIETHOADON);
            // 
            // reportHoaDon
            // 
            this.reportHoaDon.BackColor = System.Drawing.Color.SandyBrown;
            reportDataSource2.Name = "XuatHDDataSet";
            reportDataSource2.Value = this.CHITIETHOADONBindingSource;
            this.reportHoaDon.LocalReport.DataSources.Add(reportDataSource2);
            this.reportHoaDon.LocalReport.ReportEmbeddedResource = "QL_CAFE.InHoaDonReport.rdlc";
            this.reportHoaDon.Location = new System.Drawing.Point(3, 83);
            this.reportHoaDon.Name = "reportHoaDon";
            this.reportHoaDon.ServerReport.BearerToken = null;
            this.reportHoaDon.Size = new System.Drawing.Size(743, 435);
            this.reportHoaDon.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnHD);
            this.panel1.Controls.Add(this.reportHoaDon);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 540);
            this.panel1.TabIndex = 1;
            // 
            // btnHD
            // 
            this.btnHD.AutoSize = true;
            this.btnHD.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD.Location = new System.Drawing.Point(248, 18);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(224, 51);
            this.btnHD.TabIndex = 1;
            this.btnHD.Text = "HOÁ ĐƠN";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("VNI-Top", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThoat.Location = new System.Drawing.Point(715, -10);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 40);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.TabStop = false;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(761, 564);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInHoaDon";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CHITIETHOADONBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource CHITIETHOADONBindingSource;
        private System.Windows.Forms.Label btnHD;
        private System.Windows.Forms.Button btnThoat;
    }
}