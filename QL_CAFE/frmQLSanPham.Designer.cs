
namespace QL_CAFE
{
    partial class frmQLSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSanPham));
            this.grbLoai = new System.Windows.Forms.GroupBox();
            this.btnThemLoai = new System.Windows.Forms.Button();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.labHoTen = new System.Windows.Forms.Label();
            this.grbSanPham = new System.Windows.Forms.GroupBox();
            this.cmbTLoai = new System.Windows.Forms.ComboBox();
            this.labChucVu = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhaSX = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.dgvLoai = new System.Windows.Forms.DataGridView();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbLoai.SuspendLayout();
            this.grbSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLoai
            // 
            this.grbLoai.Controls.Add(this.btnThemLoai);
            this.grbLoai.Controls.Add(this.txtMaLoai);
            this.grbLoai.Controls.Add(this.txtTenLoai);
            this.grbLoai.Controls.Add(this.labID);
            this.grbLoai.Controls.Add(this.labHoTen);
            this.grbLoai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLoai.Location = new System.Drawing.Point(12, 34);
            this.grbLoai.Name = "grbLoai";
            this.grbLoai.Size = new System.Drawing.Size(380, 110);
            this.grbLoai.TabIndex = 0;
            this.grbLoai.TabStop = false;
            this.grbLoai.Text = "Quản Lý Loại";
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.ForeColor = System.Drawing.Color.Maroon;
            this.btnThemLoai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThemLoai.Location = new System.Drawing.Point(272, 36);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(99, 59);
            this.btnThemLoai.TabIndex = 4;
            this.btnThemLoai.Text = "Thêm";
            this.btnThemLoai.UseVisualStyleBackColor = true;
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtMaLoai.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaLoai.ForeColor = System.Drawing.Color.Maroon;
            this.txtMaLoai.Location = new System.Drawing.Point(111, 33);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(147, 27);
            this.txtMaLoai.TabIndex = 20;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtTenLoai.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTenLoai.ForeColor = System.Drawing.Color.Maroon;
            this.txtTenLoai.Location = new System.Drawing.Point(111, 69);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(147, 27);
            this.txtTenLoai.TabIndex = 21;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labID.Location = new System.Drawing.Point(24, 35);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(71, 19);
            this.labID.TabIndex = 22;
            this.labID.Text = "Mã Loại";
            // 
            // labHoTen
            // 
            this.labHoTen.AutoSize = true;
            this.labHoTen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labHoTen.Location = new System.Drawing.Point(23, 72);
            this.labHoTen.Name = "labHoTen";
            this.labHoTen.Size = new System.Drawing.Size(74, 19);
            this.labHoTen.TabIndex = 23;
            this.labHoTen.Text = "Tên Loại";
            // 
            // grbSanPham
            // 
            this.grbSanPham.Controls.Add(this.cmbTLoai);
            this.grbSanPham.Controls.Add(this.labChucVu);
            this.grbSanPham.Controls.Add(this.btnThemSP);
            this.grbSanPham.Controls.Add(this.label3);
            this.grbSanPham.Controls.Add(this.label6);
            this.grbSanPham.Controls.Add(this.label1);
            this.grbSanPham.Controls.Add(this.txtNhaSX);
            this.grbSanPham.Controls.Add(this.txtMaSP);
            this.grbSanPham.Controls.Add(this.label5);
            this.grbSanPham.Controls.Add(this.label2);
            this.grbSanPham.Controls.Add(this.txtGiaBan);
            this.grbSanPham.Controls.Add(this.txtGiaMua);
            this.grbSanPham.Controls.Add(this.txtTenSP);
            this.grbSanPham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSanPham.Location = new System.Drawing.Point(12, 150);
            this.grbSanPham.Name = "grbSanPham";
            this.grbSanPham.Size = new System.Drawing.Size(380, 360);
            this.grbSanPham.TabIndex = 0;
            this.grbSanPham.TabStop = false;
            this.grbSanPham.Text = "Quản Lý Sản Phẩm";
            // 
            // cmbTLoai
            // 
            this.cmbTLoai.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmbTLoai.FormattingEnabled = true;
            this.cmbTLoai.Location = new System.Drawing.Point(166, 123);
            this.cmbTLoai.Name = "cmbTLoai";
            this.cmbTLoai.Size = new System.Drawing.Size(204, 27);
            this.cmbTLoai.TabIndex = 25;
            // 
            // labChucVu
            // 
            this.labChucVu.AutoSize = true;
            this.labChucVu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labChucVu.Location = new System.Drawing.Point(32, 126);
            this.labChucVu.Name = "labChucVu";
            this.labChucVu.Size = new System.Drawing.Size(74, 19);
            this.labChucVu.TabIndex = 24;
            this.labChucVu.Text = "Tên Loại";
            // 
            // btnThemSP
            // 
            this.btnThemSP.ForeColor = System.Drawing.Color.Maroon;
            this.btnThemSP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThemSP.Location = new System.Drawing.Point(111, 300);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(147, 54);
            this.btnThemSP.TabIndex = 4;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(27, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Giá Bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(28, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Giá Mua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(28, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // txtNhaSX
            // 
            this.txtNhaSX.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtNhaSX.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNhaSX.ForeColor = System.Drawing.Color.Maroon;
            this.txtNhaSX.Location = new System.Drawing.Point(166, 165);
            this.txtNhaSX.Name = "txtNhaSX";
            this.txtNhaSX.Size = new System.Drawing.Size(204, 27);
            this.txtNhaSX.TabIndex = 20;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMaSP.ForeColor = System.Drawing.Color.Maroon;
            this.txtMaSP.Location = new System.Drawing.Point(166, 36);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(206, 27);
            this.txtMaSP.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(27, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nhà Sản Xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(29, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtGiaBan.ForeColor = System.Drawing.Color.Maroon;
            this.txtGiaBan.Location = new System.Drawing.Point(166, 248);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(202, 27);
            this.txtGiaBan.TabIndex = 21;
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtGiaMua.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtGiaMua.ForeColor = System.Drawing.Color.Maroon;
            this.txtGiaMua.Location = new System.Drawing.Point(166, 206);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(203, 27);
            this.txtGiaMua.TabIndex = 21;
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTenSP.ForeColor = System.Drawing.Color.Maroon;
            this.txtTenSP.Location = new System.Drawing.Point(166, 81);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(206, 27);
            this.txtTenSP.TabIndex = 21;
            // 
            // dgvLoai
            // 
            this.dgvLoai.AllowUserToAddRows = false;
            this.dgvLoai.AllowUserToDeleteRows = false;
            this.dgvLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenLoai});
            this.dgvLoai.Location = new System.Drawing.Point(398, 42);
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.ReadOnly = true;
            this.dgvLoai.RowHeadersWidth = 51;
            this.dgvLoai.RowTemplate.Height = 24;
            this.dgvLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoai.Size = new System.Drawing.Size(370, 102);
            this.dgvLoai.TabIndex = 1;
            // 
            // MaLoai
            // 
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.MinimumWidth = 6;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            this.MaLoai.Width = 125;
            // 
            // TenLoai
            // 
            this.TenLoai.HeaderText = "Tên Loại";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            this.TenLoai.Width = 125;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.TenL,
            this.NhaSX,
            this.GiaMua,
            this.GiaBan});
            this.dgvSanPham.Location = new System.Drawing.Point(398, 150);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(370, 360);
            this.dgvSanPham.TabIndex = 1;
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 78;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 84;
            // 
            // TenL
            // 
            this.TenL.HeaderText = "Tên Loai";
            this.TenL.MinimumWidth = 6;
            this.TenL.Name = "TenL";
            this.TenL.ReadOnly = true;
            this.TenL.Width = 93;
            // 
            // NhaSX
            // 
            this.NhaSX.HeaderText = "Nhà SX";
            this.NhaSX.MinimumWidth = 6;
            this.NhaSX.Name = "NhaSX";
            this.NhaSX.ReadOnly = true;
            this.NhaSX.Width = 85;
            // 
            // GiaMua
            // 
            this.GiaMua.HeaderText = "Giá Mua";
            this.GiaMua.MinimumWidth = 6;
            this.GiaMua.Name = "GiaMua";
            this.GiaMua.ReadOnly = true;
            this.GiaMua.Width = 90;
            // 
            // GiaBan
            // 
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            this.GiaBan.Width = 88;
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
            this.btnThoat.Location = new System.Drawing.Point(740, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 40);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.TabStop = false;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(780, 530);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.dgvLoai);
            this.Controls.Add(this.grbSanPham);
            this.Controls.Add(this.grbLoai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLSanPham";
            this.Load += new System.EventHandler(this.frmQLSanPham_Load);
            this.grbLoai.ResumeLayout(false);
            this.grbLoai.PerformLayout();
            this.grbSanPham.ResumeLayout(false);
            this.grbSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLoai;
        private System.Windows.Forms.GroupBox grbSanPham;
        private System.Windows.Forms.DataGridView dgvLoai;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.Button btnThemLoai;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhaSX;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cmbTLoai;
        private System.Windows.Forms.Label labChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.Button btnThoat;
    }
}