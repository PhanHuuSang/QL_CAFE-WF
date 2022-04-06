using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_CAFE.Models;

namespace QL_CAFE
{
    public partial class frmQuanLyNhanVien : Form
    {
        QuanLyCaFe_DBContext context = new QuanLyCaFe_DBContext();
        public string STK;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            List<TAIKHOAN> listTK = context.TAIKHOANs.ToList();
            tabPage1.Text = "Tìm kiếm nhân viên";
            tabPage2.Text = "Thay đổi thông tin";
            btnSTK.Text = STK;
            ThemcmbNS();
            ThemcmbChucvu();
            rdioToanBo.Checked = true;
            ChuyenDuLieuDGV(listTK);
        }

        private void ThemcmbNS()
        {
            List<int> namSinh = new List<int>();
            for (int i = 1980; i <= DateTime.Now.Year; i++)
                namSinh.Add(i);
            cmbNamSinh.DataSource = namSinh;
            cmbNamSinh.DisplayMember = "";

        }

        private void ThemcmbChucvu()
        {
            List<string> chucvu = new List<string> { "Quản Lý", "Nhân Viên" };
     
            cmbChucVu.DataSource = chucvu;
            cmbTChucVu.DataSource = chucvu;
            cmbChucVu.DisplayMember = "";
            cmbTChucVu.DisplayMember = "";

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ChuyenDuLieuDGV(List<TAIKHOAN> TK)
        {
            dgvQuanLyNV.Rows.Clear();
            foreach (TAIKHOAN item in TK)
            {
                int index = dgvQuanLyNV.Rows.Add();
                dgvQuanLyNV.Rows[index].Cells[0].Value = item.ID;
                dgvQuanLyNV.Rows[index].Cells[1].Value = item.NHANVIEN.HOTEN;
                dgvQuanLyNV.Rows[index].Cells[2].Value = item.TK;
                dgvQuanLyNV.Rows[index].Cells[3].Value = item.MK;
                dgvQuanLyNV.Rows[index].Cells[4].Value = item.QUYEN;
                dgvQuanLyNV.Rows[index].Cells[5].Value = item.NHANVIEN.NAMSINH;
                dgvQuanLyNV.Rows[index].Cells[6].Value = item.NHANVIEN.SDT;
                dgvQuanLyNV.Rows[index].Cells[7].Value = item.NHANVIEN.DIACHI;
                dgvQuanLyNV.Rows[index].Cells[8].Value = item.NHANVIEN.TKNGANHANG;
                dgvQuanLyNV.Refresh();
            }

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            NHANVIEN NV = new NHANVIEN();
            TAIKHOAN TK = new TAIKHOAN();
            try
            {
                if (txtMatKhau.Text == txtNhapLai.Text)
                {
                    NV.HOTEN = txtHoTen.Text;
                    NV.NAMSINH = int.Parse(txtNamSinh.Text);
                    NV.SDT = txtSDT.Text;
                    NV.DIACHI = txtDiaChi.Text;
                    NV.TKNGANHANG = txtBanKing.Text;
                    context.NHANVIENs.AddOrUpdate(NV);
                    TK.TK = txtTaiKhoan.Text;
                    TK.MK = txtMatKhau.Text;
                    TK.ID = NV.ID;
                    TK.QUYEN = cmbChucVu.Text;
                    context.TAIKHOANs.AddOrUpdate(TK);
                    context.SaveChanges();
                    List<TAIKHOAN> listTK = context.TAIKHOANs.ToList();
                    ChuyenDuLieuDGV(listTK);
                    if (context.TAIKHOANs.Any(nv => nv.TK == txtTaiKhoan.Text))
                        MessageBox.Show("Cập nhập thành công");
                    else
                        MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu cho khớp");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }



        }
        private void dgvQuanLyNV_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoTen.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTKHoTen.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTaiKhoan.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTKTaiKhoan.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMatKhau.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNhapLai.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbChucVu.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbTChucVu.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNamSinh.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbNamSinh.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtSDT.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtDiaChi.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtBanKing.Text = dgvQuanLyNV.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            try
            {
                List<TAIKHOAN> listTK = context.TAIKHOANs.ToList();
                if (rdioToanBo.Checked == true)
                    listTK = context.TAIKHOANs.ToList();
                else if (rdoID.Checked == true)
                    listTK = context.TAIKHOANs.Where(tk => tk.ID.ToString() == txtID.Text).ToList();
                else if (rdoHoTen.Checked == true)
                    listTK = context.TAIKHOANs.Where(tk => tk.NHANVIEN.HOTEN == txtTKHoTen.Text).ToList();
                else if (rdoNamSinh.Checked == true)
                    listTK = context.TAIKHOANs.Where(tk => tk.NHANVIEN.NAMSINH.ToString() == cmbNamSinh.Text).ToList();
                else if (rdoChucVu.Checked == true)
                    listTK = context.TAIKHOANs.Where(tk => tk.QUYEN == cmbChucVu.Text).ToList();
                else if (rdoTaiKhoan.Checked == true)
                    listTK = context.TAIKHOANs.Where(tk => tk.TK.ToString() == txtTKTaiKhoan.Text).ToList();
                ChuyenDuLieuDGV(listTK);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy thông tin, Nhập Lại", "Thông Báo");
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          

            try
            {
                NHANVIEN NV = context.NHANVIENs.Where(nv => nv.ID.ToString() == txtID.Text).FirstOrDefault();
                TAIKHOAN TK = context.TAIKHOANs.Where(nv => nv.NHANVIEN.ID.ToString() == txtID.Text).FirstOrDefault();
                if(TK.TK == btnSTK.Text)
                    MessageBox.Show("Tài khoản đang được sử dụng","Chú ý");
                else
                {
                 context.NHANVIENs.Remove(NV);
                 context.TAIKHOANs.Remove(TK);
                context.SaveChanges();
                MessageBox.Show("Xoá ID " + txtID.Text + " Thành Công");
                rdioToanBo.Checked = true;
                List<TAIKHOAN> listTK = context.TAIKHOANs.ToList();
                ChuyenDuLieuDGV(listTK);
                }    
                

            }

            catch
            {
                MessageBox.Show("Không tìm thấy ID để xoá");
            }
        }


    }
}
