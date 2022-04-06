
namespace QL_CAFE
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaiKhoanNho = new System.Windows.Forms.Button();
            this.btnMatKhauNho = new System.Windows.Forms.Button();
            this.pnlManHinh = new System.Windows.Forms.Panel();
            this.pnlKhungTren = new System.Windows.Forms.Panel();
            this.btnTaiKhoanLon = new System.Windows.Forms.Button();
            this.pnlAnTKL = new System.Windows.Forms.Panel();
            this.pnlAnTKN = new System.Windows.Forms.Panel();
            this.pnlHienTKN = new System.Windows.Forms.Panel();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.pnlKhungDuoi = new System.Windows.Forms.Panel();
            this.btnMatKhauLon = new System.Windows.Forms.Button();
            this.pnlAnMKL = new System.Windows.Forms.Panel();
            this.pnlAnMKN = new System.Windows.Forms.Panel();
            this.pnlHienMKN = new System.Windows.Forms.Panel();
            this.btnLoGo = new System.Windows.Forms.Button();
            this.pnlManHinh.SuspendLayout();
            this.pnlKhungTren.SuspendLayout();
            this.pnlKhungDuoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Maroon;
            this.btnDangNhap.Location = new System.Drawing.Point(12, 198);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(243, 59);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.TabStop = false;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDangNhap_KeyDown);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Maroon;
            this.txtMatKhau.Location = new System.Drawing.Point(1, 28);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '✿';
            this.txtMatKhau.Size = new System.Drawing.Size(223, 46);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.TabIndexChanged += new System.EventHandler(this.btnTaiKhoanLon_MouseHover);
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyDown);
            this.txtMatKhau.Leave += new System.EventHandler(this.btnTaiKhoanLon_MouseHover);
            this.txtMatKhau.MouseLeave += new System.EventHandler(this.txtMatKhau_MouseLeave);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("VNI-Top", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoat.Image = global::QL_CAFE.Properties.Resources.iconoff;
            this.btnThoat.Location = new System.Drawing.Point(510, 1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(40, 40);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.TabStop = false;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaiKhoanNho
            // 
            this.btnTaiKhoanNho.BackColor = System.Drawing.Color.Transparent;
            this.btnTaiKhoanNho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTaiKhoanNho.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoanNho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnTaiKhoanNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoanNho.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoanNho.ForeColor = System.Drawing.Color.Maroon;
            this.btnTaiKhoanNho.Location = new System.Drawing.Point(277, 1);
            this.btnTaiKhoanNho.Name = "btnTaiKhoanNho";
            this.btnTaiKhoanNho.Size = new System.Drawing.Size(103, 24);
            this.btnTaiKhoanNho.TabIndex = 1;
            this.btnTaiKhoanNho.TabStop = false;
            this.btnTaiKhoanNho.Text = "Tài Khoản";
            this.btnTaiKhoanNho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoanNho.UseVisualStyleBackColor = false;
            // 
            // btnMatKhauNho
            // 
            this.btnMatKhauNho.BackColor = System.Drawing.Color.Transparent;
            this.btnMatKhauNho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMatKhauNho.FlatAppearance.BorderSize = 0;
            this.btnMatKhauNho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnMatKhauNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatKhauNho.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatKhauNho.ForeColor = System.Drawing.Color.Maroon;
            this.btnMatKhauNho.Location = new System.Drawing.Point(277, 2);
            this.btnMatKhauNho.Name = "btnMatKhauNho";
            this.btnMatKhauNho.Size = new System.Drawing.Size(105, 24);
            this.btnMatKhauNho.TabIndex = 4;
            this.btnMatKhauNho.TabStop = false;
            this.btnMatKhauNho.Text = "Mật Khẩu";
            this.btnMatKhauNho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatKhauNho.UseVisualStyleBackColor = false;
            // 
            // pnlManHinh
            // 
            this.pnlManHinh.Controls.Add(this.pnlKhungTren);
            this.pnlManHinh.Controls.Add(this.pnlKhungDuoi);
            this.pnlManHinh.Controls.Add(this.btnDangNhap);
            this.pnlManHinh.Location = new System.Drawing.Point(246, 12);
            this.pnlManHinh.Name = "pnlManHinh";
            this.pnlManHinh.Size = new System.Drawing.Size(293, 260);
            this.pnlManHinh.TabIndex = 5;
            // 
            // pnlKhungTren
            // 
            this.pnlKhungTren.Controls.Add(this.btnTaiKhoanNho);
            this.pnlKhungTren.Controls.Add(this.btnTaiKhoanLon);
            this.pnlKhungTren.Controls.Add(this.pnlAnTKL);
            this.pnlKhungTren.Controls.Add(this.pnlAnTKN);
            this.pnlKhungTren.Controls.Add(this.pnlHienTKN);
            this.pnlKhungTren.Controls.Add(this.txtTaiKhoan);
            this.pnlKhungTren.Location = new System.Drawing.Point(30, 33);
            this.pnlKhungTren.Name = "pnlKhungTren";
            this.pnlKhungTren.Size = new System.Drawing.Size(494, 69);
            this.pnlKhungTren.TabIndex = 5;
            // 
            // btnTaiKhoanLon
            // 
            this.btnTaiKhoanLon.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnTaiKhoanLon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTaiKhoanLon.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoanLon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoanLon.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoanLon.ForeColor = System.Drawing.Color.Maroon;
            this.btnTaiKhoanLon.Location = new System.Drawing.Point(1, 28);
            this.btnTaiKhoanLon.Name = "btnTaiKhoanLon";
            this.btnTaiKhoanLon.Size = new System.Drawing.Size(223, 38);
            this.btnTaiKhoanLon.TabIndex = 0;
            this.btnTaiKhoanLon.TabStop = false;
            this.btnTaiKhoanLon.Text = "Nhập Tài Khoản";
            this.btnTaiKhoanLon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoanLon.UseVisualStyleBackColor = false;
            this.btnTaiKhoanLon.MouseHover += new System.EventHandler(this.btnTaiKhoanLon_MouseHover);
            // 
            // pnlAnTKL
            // 
            this.pnlAnTKL.Location = new System.Drawing.Point(268, 26);
            this.pnlAnTKL.Name = "pnlAnTKL";
            this.pnlAnTKL.Size = new System.Drawing.Size(223, 38);
            this.pnlAnTKL.TabIndex = 7;
            // 
            // pnlAnTKN
            // 
            this.pnlAnTKN.Location = new System.Drawing.Point(387, 1);
            this.pnlAnTKN.Name = "pnlAnTKN";
            this.pnlAnTKN.Size = new System.Drawing.Size(105, 21);
            this.pnlAnTKN.TabIndex = 6;
            // 
            // pnlHienTKN
            // 
            this.pnlHienTKN.Location = new System.Drawing.Point(1, 1);
            this.pnlHienTKN.Name = "pnlHienTKN";
            this.pnlHienTKN.Size = new System.Drawing.Size(105, 21);
            this.pnlHienTKN.TabIndex = 6;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Maroon;
            this.txtTaiKhoan.Location = new System.Drawing.Point(1, 28);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(223, 46);
            this.txtTaiKhoan.TabIndex = 0;
            this.txtTaiKhoan.TabIndexChanged += new System.EventHandler(this.btnMatKhauLon_MouseHover);
            this.txtTaiKhoan.Leave += new System.EventHandler(this.btnMatKhauLon_MouseHover);
            this.txtTaiKhoan.MouseLeave += new System.EventHandler(this.txtTaiKhoan_MouseLeave);
            // 
            // pnlKhungDuoi
            // 
            this.pnlKhungDuoi.Controls.Add(this.btnMatKhauLon);
            this.pnlKhungDuoi.Controls.Add(this.pnlAnMKL);
            this.pnlKhungDuoi.Controls.Add(this.btnMatKhauNho);
            this.pnlKhungDuoi.Controls.Add(this.pnlAnMKN);
            this.pnlKhungDuoi.Controls.Add(this.pnlHienMKN);
            this.pnlKhungDuoi.Controls.Add(this.txtMatKhau);
            this.pnlKhungDuoi.Location = new System.Drawing.Point(31, 106);
            this.pnlKhungDuoi.Name = "pnlKhungDuoi";
            this.pnlKhungDuoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlKhungDuoi.Size = new System.Drawing.Size(493, 69);
            this.pnlKhungDuoi.TabIndex = 5;
            // 
            // btnMatKhauLon
            // 
            this.btnMatKhauLon.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnMatKhauLon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMatKhauLon.FlatAppearance.BorderSize = 0;
            this.btnMatKhauLon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatKhauLon.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatKhauLon.ForeColor = System.Drawing.Color.Maroon;
            this.btnMatKhauLon.Location = new System.Drawing.Point(1, 28);
            this.btnMatKhauLon.Name = "btnMatKhauLon";
            this.btnMatKhauLon.Size = new System.Drawing.Size(223, 38);
            this.btnMatKhauLon.TabIndex = 5;
            this.btnMatKhauLon.TabStop = false;
            this.btnMatKhauLon.Text = "Nhập Mật Khẩu";
            this.btnMatKhauLon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatKhauLon.UseVisualStyleBackColor = false;
            this.btnMatKhauLon.MouseHover += new System.EventHandler(this.btnMatKhauLon_MouseHover);
            // 
            // pnlAnMKL
            // 
            this.pnlAnMKL.Location = new System.Drawing.Point(268, 26);
            this.pnlAnMKL.Name = "pnlAnMKL";
            this.pnlAnMKL.Size = new System.Drawing.Size(223, 38);
            this.pnlAnMKL.TabIndex = 7;
            // 
            // pnlAnMKN
            // 
            this.pnlAnMKN.Location = new System.Drawing.Point(386, 2);
            this.pnlAnMKN.Name = "pnlAnMKN";
            this.pnlAnMKN.Size = new System.Drawing.Size(105, 21);
            this.pnlAnMKN.TabIndex = 6;
            // 
            // pnlHienMKN
            // 
            this.pnlHienMKN.Location = new System.Drawing.Point(1, 3);
            this.pnlHienMKN.Name = "pnlHienMKN";
            this.pnlHienMKN.Size = new System.Drawing.Size(105, 21);
            this.pnlHienMKN.TabIndex = 6;
            // 
            // btnLoGo
            // 
            this.btnLoGo.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLoGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoGo.FlatAppearance.BorderSize = 0;
            this.btnLoGo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btnLoGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoGo.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoGo.Image = ((System.Drawing.Image)(resources.GetObject("btnLoGo.Image")));
            this.btnLoGo.Location = new System.Drawing.Point(12, 34);
            this.btnLoGo.Name = "btnLoGo";
            this.btnLoGo.Size = new System.Drawing.Size(210, 194);
            this.btnLoGo.TabIndex = 6;
            this.btnLoGo.TabStop = false;
            this.btnLoGo.UseVisualStyleBackColor = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(9, 9);
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(551, 284);
            this.Controls.Add(this.btnLoGo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.pnlManHinh);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 10);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.pnlManHinh.ResumeLayout(false);
            this.pnlKhungTren.ResumeLayout(false);
            this.pnlKhungTren.PerformLayout();
            this.pnlKhungDuoi.ResumeLayout(false);
            this.pnlKhungDuoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaiKhoanNho;
        private System.Windows.Forms.Button btnMatKhauNho;
        private System.Windows.Forms.Panel pnlManHinh;
        private System.Windows.Forms.Panel pnlKhungDuoi;
        private System.Windows.Forms.Panel pnlKhungTren;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Panel pnlHienTKN;
        private System.Windows.Forms.Panel pnlHienMKN;
        private System.Windows.Forms.Panel pnlAnTKN;
        private System.Windows.Forms.Panel pnlAnMKN;
        private System.Windows.Forms.Button btnMatKhauLon;
        private System.Windows.Forms.Panel pnlAnMKL;
        private System.Windows.Forms.Button btnTaiKhoanLon;
        private System.Windows.Forms.Panel pnlAnTKL;
        private System.Windows.Forms.Button btnLoGo;
    }
}

