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
    public partial class frmThongTinTaiKhoan : Form
    {
        QuanLyCaFe_DBContext context = new QuanLyCaFe_DBContext();
        public string STK;
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            pnlDoiMK.Hide();
            ChuyenDuLieu();
        }

        private void ChuyenDuLieu()
        {   
            TAIKHOAN TK = context.TAIKHOANs.Where(tk => tk.TK == STK).FirstOrDefault();
            btnTaiKhoan.Text ="Tài Khoản: " + TK.TK;
            btnHoTen.Text = TK.QUYEN +": "+ TK.NHANVIEN.HOTEN;
            txtSDT.Text = TK.NHANVIEN.SDT.ToString();
            txtNamSinh.Text = TK.NHANVIEN.NAMSINH.ToString();
            txtDiaChi.Text = TK.NHANVIEN.DIACHI;
            txtNganHang.Text = TK.NHANVIEN .TKNGANHANG.ToString();

        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            try
            {
                TAIKHOAN TK = context.TAIKHOANs.Where(tk => tk.TK == STK).FirstOrDefault();
                TK.NHANVIEN.SDT = txtSDT.Text;
                TK.NHANVIEN.NAMSINH = int.Parse(txtNamSinh.Text);
                TK.NHANVIEN.DIACHI = txtDiaChi.Text;
                TK.NHANVIEN.TKNGANHANG = txtNganHang.Text;
                MessageBox.Show("Cập Nhập Thành Công");
                context.SaveChanges();
                frmThongTinTaiKhoan_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Cập Nhập Thất Bại");
            }
           
        }


        private void btnDoiMatKhauC_Click(object sender, EventArgs e)
        {
            TAIKHOAN TK = context.TAIKHOANs.Where(tk => tk.TK == STK).FirstOrDefault();
            btnDoiMatKhauM.Show();
            if (txtMatKhauHT.Text == TK.MK && txtMatKhauMoi.Text == txtNhapLaiMatKhau.Text)
            {
                TK.MK = txtMatKhauMoi.Text;
                context.SaveChanges();
                MessageBox.Show("Đổi Mật Khẩu Thành Công");
            }
            else
                MessageBox.Show("Đổi Mật Khẩu Thất Bại");

        }

        private void btnDoiMatKhauM_Click(object sender, EventArgs e)
        {
            pnlDoiMK.Show();
            pnlThongTinTK.Hide();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            pnlDoiMK.Hide();
            pnlThongTinTK.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
