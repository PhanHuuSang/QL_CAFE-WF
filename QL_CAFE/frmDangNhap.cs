using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_CAFE.Models;


namespace QL_CAFE
{
    public partial class frmDangNhap : Form
    {
        public delegate void ChungThucTaiKhoan(object sender);
        public event ChungThucTaiKhoan chungThucThongTinTaiKhoan;
        QuanLyCaFe_DBContext context = new QuanLyCaFe_DBContext();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (context.TAIKHOANs.Any(tk => tk.TK == txtTaiKhoan.Text && tk.MK == txtMatKhau.Text))
            {
                chungThucThongTinTaiKhoan(this.txtTaiKhoan.Text);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);                
            }


          
;                 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void btnTaiKhoanLon_MouseHover(object sender, EventArgs e)
        {
            btnTaiKhoanLon.Location = pnlAnTKL.Location;
            btnTaiKhoanNho.Location = pnlHienTKN.Location;
        }

        private void txtTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                btnTaiKhoanLon.Location = txtTaiKhoan.Location;
                btnTaiKhoanNho.Location = pnlAnTKN.Location;
            }
  
        }

        private void btnMatKhauLon_MouseHover(object sender, EventArgs e)
        {
            btnMatKhauLon.Location = pnlAnMKL.Location;
            btnMatKhauNho.Location = pnlHienMKN.Location;
        }

        private void txtMatKhau_MouseLeave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                btnMatKhauLon.Location = txtMatKhau.Location;
                btnMatKhauNho.Location = pnlAnMKN.Location;
            }
        }


    }
}

       