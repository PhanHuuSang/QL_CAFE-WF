
namespace QL_CAFE
{
    partial class frmQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhanVien));
            this.grbQuanLyNhanVien = new System.Windows.Forms.GroupBox();
            this.tabTimKiem = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.btnSTK = new System.Windows.Forms.Button();
            this.cmbTChucVu = new System.Windows.Forms.ComboBox();
            this.labChucVu = new System.Windows.Forms.Label();
            this.labTaiKhoan = new System.Windows.Forms.Label();
            this.txtTKTaiKhoan = new System.Windows.Forms.TextBox();
            this.rdoChucVu = new System.Windows.Forms.RadioButton();
            this.rdoTaiKhoan = new System.Windows.Forms.RadioButton();
            this.cmbNamSinh = new System.Windows.Forms.ComboBox();
            this.labXuat = new System.Windows.Forms.Label();
            this.rdoNamSinh = new System.Windows.Forms.RadioButton();
            this.rdoHoTen = new System.Windows.Forms.RadioButton();
            this.rdioToanBo = new System.Windows.Forms.RadioButton();
            this.rdoID = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.labNamSinh = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.labHoTen = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTKHoTen = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlDangKy = new System.Windows.Forms.Panel();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBanKing = new System.Windows.Forms.TextBox();
            this.labHTen = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dgvQuanLyNV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Banking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbQuanLyNhanVien.SuspendLayout();
            this.tabTimKiem.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbQuanLyNhanVien
            // 
            this.grbQuanLyNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.grbQuanLyNhanVien.Controls.Add(this.tabTimKiem);
            this.grbQuanLyNhanVien.Controls.Add(this.dgvQuanLyNV);
            this.grbQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.grbQuanLyNhanVien, "grbQuanLyNhanVien");
            this.grbQuanLyNhanVien.Name = "grbQuanLyNhanVien";
            this.grbQuanLyNhanVien.TabStop = false;
            // 
            // tabTimKiem
            // 
            this.tabTimKiem.Controls.Add(this.tabPage1);
            this.tabTimKiem.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabTimKiem, "tabTimKiem");
            this.tabTimKiem.Name = "tabTimKiem";
            this.tabTimKiem.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlTimKiem);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlTimKiem
            // 
            this.pnlTimKiem.BackColor = System.Drawing.Color.SandyBrown;
            resources.ApplyResources(this.pnlTimKiem, "pnlTimKiem");
            this.pnlTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTimKiem.Controls.Add(this.btnSTK);
            this.pnlTimKiem.Controls.Add(this.cmbTChucVu);
            this.pnlTimKiem.Controls.Add(this.labChucVu);
            this.pnlTimKiem.Controls.Add(this.labTaiKhoan);
            this.pnlTimKiem.Controls.Add(this.txtTKTaiKhoan);
            this.pnlTimKiem.Controls.Add(this.rdoChucVu);
            this.pnlTimKiem.Controls.Add(this.rdoTaiKhoan);
            this.pnlTimKiem.Controls.Add(this.cmbNamSinh);
            this.pnlTimKiem.Controls.Add(this.labXuat);
            this.pnlTimKiem.Controls.Add(this.rdoNamSinh);
            this.pnlTimKiem.Controls.Add(this.rdoHoTen);
            this.pnlTimKiem.Controls.Add(this.rdioToanBo);
            this.pnlTimKiem.Controls.Add(this.rdoID);
            this.pnlTimKiem.Controls.Add(this.btnXoa);
            this.pnlTimKiem.Controls.Add(this.labNamSinh);
            this.pnlTimKiem.Controls.Add(this.labID);
            this.pnlTimKiem.Controls.Add(this.labHoTen);
            this.pnlTimKiem.Controls.Add(this.txtID);
            this.pnlTimKiem.Controls.Add(this.txtTKHoTen);
            this.pnlTimKiem.Name = "pnlTimKiem";
            // 
            // btnSTK
            // 
            resources.ApplyResources(this.btnSTK, "btnSTK");
            this.btnSTK.Name = "btnSTK";
            this.btnSTK.UseVisualStyleBackColor = true;
            // 
            // cmbTChucVu
            // 
            this.cmbTChucVu.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmbTChucVu.FormattingEnabled = true;
            resources.ApplyResources(this.cmbTChucVu, "cmbTChucVu");
            this.cmbTChucVu.Name = "cmbTChucVu";
            // 
            // labChucVu
            // 
            resources.ApplyResources(this.labChucVu, "labChucVu");
            this.labChucVu.Name = "labChucVu";
            // 
            // labTaiKhoan
            // 
            resources.ApplyResources(this.labTaiKhoan, "labTaiKhoan");
            this.labTaiKhoan.Name = "labTaiKhoan";
            // 
            // txtTKTaiKhoan
            // 
            this.txtTKTaiKhoan.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtTKTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTKTaiKhoan.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.txtTKTaiKhoan, "txtTKTaiKhoan");
            this.txtTKTaiKhoan.Name = "txtTKTaiKhoan";
            // 
            // rdoChucVu
            // 
            resources.ApplyResources(this.rdoChucVu, "rdoChucVu");
            this.rdoChucVu.Name = "rdoChucVu";
            this.rdoChucVu.TabStop = true;
            this.rdoChucVu.UseVisualStyleBackColor = true;
            this.rdoChucVu.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rdoTaiKhoan
            // 
            resources.ApplyResources(this.rdoTaiKhoan, "rdoTaiKhoan");
            this.rdoTaiKhoan.Name = "rdoTaiKhoan";
            this.rdoTaiKhoan.TabStop = true;
            this.rdoTaiKhoan.UseVisualStyleBackColor = true;
            this.rdoTaiKhoan.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cmbNamSinh
            // 
            this.cmbNamSinh.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmbNamSinh.FormattingEnabled = true;
            resources.ApplyResources(this.cmbNamSinh, "cmbNamSinh");
            this.cmbNamSinh.Name = "cmbNamSinh";
            // 
            // labXuat
            // 
            resources.ApplyResources(this.labXuat, "labXuat");
            this.labXuat.Name = "labXuat";
            // 
            // rdoNamSinh
            // 
            resources.ApplyResources(this.rdoNamSinh, "rdoNamSinh");
            this.rdoNamSinh.Name = "rdoNamSinh";
            this.rdoNamSinh.TabStop = true;
            this.rdoNamSinh.UseVisualStyleBackColor = true;
            this.rdoNamSinh.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rdoHoTen
            // 
            resources.ApplyResources(this.rdoHoTen, "rdoHoTen");
            this.rdoHoTen.Name = "rdoHoTen";
            this.rdoHoTen.TabStop = true;
            this.rdoHoTen.UseVisualStyleBackColor = true;
            this.rdoHoTen.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rdioToanBo
            // 
            resources.ApplyResources(this.rdioToanBo, "rdioToanBo");
            this.rdioToanBo.Name = "rdioToanBo";
            this.rdioToanBo.TabStop = true;
            this.rdioToanBo.UseVisualStyleBackColor = true;
            this.rdioToanBo.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rdoID
            // 
            resources.ApplyResources(this.rdoID, "rdoID");
            this.rdoID.Name = "rdoID";
            this.rdoID.TabStop = true;
            this.rdoID.UseVisualStyleBackColor = true;
            this.rdoID.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labNamSinh
            // 
            resources.ApplyResources(this.labNamSinh, "labNamSinh");
            this.labNamSinh.Name = "labNamSinh";
            // 
            // labID
            // 
            resources.ApplyResources(this.labID, "labID");
            this.labID.Name = "labID";
            // 
            // labHoTen
            // 
            resources.ApplyResources(this.labHoTen, "labHoTen");
            this.labHoTen.Name = "labHoTen";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtID.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtID.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // txtTKHoTen
            // 
            this.txtTKHoTen.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtTKHoTen.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTKHoTen.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.txtTKHoTen, "txtTKHoTen");
            this.txtTKHoTen.Name = "txtTKHoTen";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlDangKy);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlDangKy
            // 
            this.pnlDangKy.BackColor = System.Drawing.Color.SandyBrown;
            resources.ApplyResources(this.pnlDangKy, "pnlDangKy");
            this.pnlDangKy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDangKy.Controls.Add(this.cmbChucVu);
            this.pnlDangKy.Controls.Add(this.btnDangKy);
            this.pnlDangKy.Controls.Add(this.label9);
            this.pnlDangKy.Controls.Add(this.label8);
            this.pnlDangKy.Controls.Add(this.label7);
            this.pnlDangKy.Controls.Add(this.label1);
            this.pnlDangKy.Controls.Add(this.label2);
            this.pnlDangKy.Controls.Add(this.txtDiaChi);
            this.pnlDangKy.Controls.Add(this.label4);
            this.pnlDangKy.Controls.Add(this.txtBanKing);
            this.pnlDangKy.Controls.Add(this.labHTen);
            this.pnlDangKy.Controls.Add(this.txtTaiKhoan);
            this.pnlDangKy.Controls.Add(this.txtHoTen);
            this.pnlDangKy.Controls.Add(this.txtNhapLai);
            this.pnlDangKy.Controls.Add(this.txtMatKhau);
            this.pnlDangKy.Controls.Add(this.txtNamSinh);
            this.pnlDangKy.Controls.Add(this.label5);
            this.pnlDangKy.Controls.Add(this.label6);
            this.pnlDangKy.Controls.Add(this.txtSDT);
            this.pnlDangKy.Name = "pnlDangKy";
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.BackColor = System.Drawing.Color.NavajoWhite;
            this.cmbChucVu.ForeColor = System.Drawing.Color.Maroon;
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Items.AddRange(new object[] {
            resources.GetString("cmbChucVu.Items"),
            resources.GetString("cmbChucVu.Items1")});
            resources.ApplyResources(this.cmbChucVu, "cmbChucVu");
            this.cmbChucVu.Name = "cmbChucVu";
            // 
            // btnDangKy
            // 
            this.btnDangKy.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.btnDangKy, "btnDangKy");
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDiaChi.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.txtDiaChi, "txtDiaChi");
            this.txtDiaChi.Name = "txtDiaChi";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtBanKing
            // 
            this.txtBanKing.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtBanKing.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBanKing.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.txtBanKing, "txtBanKing");
            this.txtBanKing.Name = "txtBanKing";
            // 
            // labHTen
            // 
            resources.ApplyResources(this.labHTen, "labHTen");
            this.labHTen.Name = "labHTen";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.txtTaiKhoan, "txtTaiKhoan");
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHoTen.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.txtHoTen, "txtHoTen");
            this.txtHoTen.Name = "txtHoTen";
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtNhapLai.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNhapLai.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.txtNhapLai, "txtNhapLai");
            this.txtNhapLai.Name = "txtNhapLai";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMatKhau.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.txtMatKhau, "txtMatKhau");
            this.txtMatKhau.Name = "txtMatKhau";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtNamSinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNamSinh.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.txtNamSinh, "txtNamSinh");
            this.txtNamSinh.Name = "txtNamSinh";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSDT.ForeColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.txtSDT, "txtSDT");
            this.txtSDT.Name = "txtSDT";
            // 
            // dgvQuanLyNV
            // 
            this.dgvQuanLyNV.AllowUserToAddRows = false;
            this.dgvQuanLyNV.AllowUserToDeleteRows = false;
            this.dgvQuanLyNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HOTEN,
            this.TAIKHOAN,
            this.MK,
            this.CV,
            this.NAMSINH,
            this.SDT,
            this.DiaChi,
            this.Banking});
            resources.ApplyResources(this.dgvQuanLyNV, "dgvQuanLyNV");
            this.dgvQuanLyNV.Name = "dgvQuanLyNV";
            this.dgvQuanLyNV.ReadOnly = true;
            this.dgvQuanLyNV.RowTemplate.Height = 24;
            this.dgvQuanLyNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLyNV.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQuanLyNV_CellMouseDown);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.HOTEN, "HOTEN");
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // TAIKHOAN
            // 
            this.TAIKHOAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.TAIKHOAN, "TAIKHOAN");
            this.TAIKHOAN.Name = "TAIKHOAN";
            this.TAIKHOAN.ReadOnly = true;
            // 
            // MK
            // 
            this.MK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.MK, "MK");
            this.MK.Name = "MK";
            this.MK.ReadOnly = true;
            // 
            // CV
            // 
            resources.ApplyResources(this.CV, "CV");
            this.CV.Name = "CV";
            this.CV.ReadOnly = true;
            // 
            // NAMSINH
            // 
            this.NAMSINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.NAMSINH, "NAMSINH");
            this.NAMSINH.Name = "NAMSINH";
            this.NAMSINH.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.SDT, "SDT");
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.DiaChi, "DiaChi");
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // Banking
            // 
            this.Banking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.Banking, "Banking");
            this.Banking.Name = "Banking";
            this.Banking.ReadOnly = true;
            // 
            // btnThoat
            // 
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btnThoat.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.TabStop = false;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataSource = typeof(QL_CAFE.Models.HOADON);
            // 
            // frmQuanLyNhanVien
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbQuanLyNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLyNhanVien";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            this.grbQuanLyNhanVien.ResumeLayout(false);
            this.tabTimKiem.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.pnlDangKy.ResumeLayout(false);
            this.pnlDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbQuanLyNhanVien;
        private System.Windows.Forms.DataGridView dgvQuanLyNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TabControl tabTimKiem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlDangKy;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBanKing;
        private System.Windows.Forms.Label labHTen;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banking;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label labNamSinh;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labHoTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTKHoTen;
        private System.Windows.Forms.RadioButton rdoNamSinh;
        private System.Windows.Forms.RadioButton rdoHoTen;
        private System.Windows.Forms.RadioButton rdoID;
        private System.Windows.Forms.RadioButton rdioToanBo;
        private System.Windows.Forms.Label labXuat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbNamSinh;
        private System.Windows.Forms.RadioButton rdoChucVu;
        private System.Windows.Forms.RadioButton rdoTaiKhoan;
        private System.Windows.Forms.ComboBox cmbTChucVu;
        private System.Windows.Forms.Label labChucVu;
        private System.Windows.Forms.Label labTaiKhoan;
        private System.Windows.Forms.TextBox txtTKTaiKhoan;
        private System.Windows.Forms.Button btnSTK;
    }
}