
namespace QL_CAFE
{
    partial class frmBaoCaoHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoHD));
            this.btnHD = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBC = new System.Windows.Forms.Panel();
            this.btntongtien = new System.Windows.Forms.Button();
            this.cmbNguoiLap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTatCa = new System.Windows.Forms.CheckBox();
            this.gdvHD = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHD
            // 
            this.btnHD.AutoSize = true;
            this.btnHD.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHD.Location = new System.Drawing.Point(3, 11);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(419, 49);
            this.btnHD.TabIndex = 1;
            this.btnHD.Text = "BÁO CÁO HOÁ ĐƠN";
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
            this.btnThoat.Location = new System.Drawing.Point(764, -39);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 40);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.TabStop = false;
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnBC
            // 
            this.btnBC.Controls.Add(this.btntongtien);
            this.btnBC.Controls.Add(this.cmbNguoiLap);
            this.btnBC.Controls.Add(this.label2);
            this.btnBC.Controls.Add(this.cbTatCa);
            this.btnBC.Controls.Add(this.gdvHD);
            this.btnBC.Controls.Add(this.button1);
            this.btnBC.Controls.Add(this.btnThoat);
            this.btnBC.Controls.Add(this.btnHD);
            this.btnBC.Location = new System.Drawing.Point(23, 12);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(852, 483);
            this.btnBC.TabIndex = 2;
            // 
            // btntongtien
            // 
            this.btntongtien.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btntongtien.Location = new System.Drawing.Point(634, 449);
            this.btntongtien.Name = "btntongtien";
            this.btntongtien.Size = new System.Drawing.Size(187, 34);
            this.btntongtien.TabIndex = 9;
            this.btntongtien.UseVisualStyleBackColor = false;
            // 
            // cmbNguoiLap
            // 
            this.cmbNguoiLap.FormattingEnabled = true;
            this.cmbNguoiLap.Location = new System.Drawing.Point(174, 78);
            this.cmbNguoiLap.Name = "cmbNguoiLap";
            this.cmbNguoiLap.Size = new System.Drawing.Size(202, 24);
            this.cmbNguoiLap.TabIndex = 8;
            this.cmbNguoiLap.SelectedIndexChanged += new System.EventHandler(this.cmbNguoiLap_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Theo người lập";
            // 
            // cbTatCa
            // 
            this.cbTatCa.AutoSize = true;
            this.cbTatCa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTatCa.Location = new System.Drawing.Point(23, 117);
            this.cbTatCa.Name = "cbTatCa";
            this.cbTatCa.Size = new System.Drawing.Size(120, 26);
            this.cbTatCa.TabIndex = 6;
            this.cbTatCa.Text = "Xem tất cả";
            this.cbTatCa.UseVisualStyleBackColor = true;
            this.cbTatCa.Click += new System.EventHandler(this.cbTatCa_Click);
            // 
            // gdvHD
            // 
            this.gdvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoHD,
            this.NGAYLAP,
            this.NguoiTao,
            this.THANHTIEN});
            this.gdvHD.Location = new System.Drawing.Point(3, 149);
            this.gdvHD.Name = "gdvHD";
            this.gdvHD.RowHeadersWidth = 51;
            this.gdvHD.RowTemplate.Height = 24;
            this.gdvHD.Size = new System.Drawing.Size(818, 302);
            this.gdvHD.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("VNI-Top", 7.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(812, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 125;
            // 
            // SoHD
            // 
            this.SoHD.HeaderText = "Số HD";
            this.SoHD.MinimumWidth = 6;
            this.SoHD.Name = "SoHD";
            this.SoHD.ReadOnly = true;
            this.SoHD.Width = 125;
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.MinimumWidth = 6;
            this.NGAYLAP.Name = "NGAYLAP";
            this.NGAYLAP.ReadOnly = true;
            this.NGAYLAP.Width = 125;
            // 
            // NguoiTao
            // 
            this.NguoiTao.HeaderText = "Người lập";
            this.NguoiTao.MinimumWidth = 6;
            this.NguoiTao.Name = "NguoiTao";
            this.NguoiTao.ReadOnly = true;
            this.NguoiTao.Width = 125;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            this.THANHTIEN.Width = 125;
            // 
            // frmBaoCaoHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(887, 517);
            this.Controls.Add(this.btnBC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCaoHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaoCaoHD";
            this.Load += new System.EventHandler(this.frmBaoCaoHD_Load);
            this.btnBC.ResumeLayout(false);
            this.btnBC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label btnHD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel btnBC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btntongtien;
        private System.Windows.Forms.ComboBox cmbNguoiLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbTatCa;
        private System.Windows.Forms.DataGridView gdvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}