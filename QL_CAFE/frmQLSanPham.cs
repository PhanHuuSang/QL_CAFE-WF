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
    public partial class frmQLSanPham : Form
    {
        QuanLyCaFe_DBContext context = new QuanLyCaFe_DBContext();
        public frmQLSanPham()
        {
            InitializeComponent();
        }

        private void frmQLSanPham_Load(object sender, EventArgs e)
        {
            ChuyendulieuLoai();
            ChuyendulieuSP();
             cmbTenLoai();
        }

        private void cmbTenLoai()
        {
            List<LOAISP> listLoai = context.LOAISPs.ToList();
            cmbTLoai.DataSource =listLoai;
            cmbTLoai.DisplayMember = "TENLOAI";
            cmbTLoai.ValueMember = "MALOAI";
        }

        private void ChuyendulieuLoai()
        {
            List<LOAISP> listLoai = context.LOAISPs.ToList();
            dgvLoai.Rows.Clear();
            foreach (LOAISP item in listLoai)
            {
                int index = dgvLoai.Rows.Add();
                dgvLoai.Rows[index].Cells[0].Value = item.MALOAI;
                dgvLoai.Rows[index].Cells[1].Value = item.TENLOAI;
                dgvLoai.Refresh();
            }
        }

        private void ChuyendulieuSP()
        {
            List<SANPHAM> listSP = context.SANPHAMs.ToList();
            dgvSanPham.Rows.Clear();
            foreach (SANPHAM item in listSP)
            {
                int index = dgvSanPham.Rows.Add();
                dgvSanPham.Rows[index].Cells[0].Value = item.MASP;
                dgvSanPham.Rows[index].Cells[1].Value = item.TENSP;
                dgvSanPham.Rows[index].Cells[2].Value = item.LOAISP.TENLOAI;
                dgvSanPham.Rows[index].Cells[3].Value = item.NHASX;
                dgvSanPham.Rows[index].Cells[4].Value = item.GIAMUA;
                dgvSanPham.Rows[index].Cells[5].Value = item.GIABAN;
                dgvSanPham.Refresh();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            try
            {
                LOAISP LoaiSP = new LOAISP();
                LoaiSP.MALOAI = txtMaLoai.Text;
                LoaiSP.TENLOAI = txtTenLoai.Text;
                context.LOAISPs.Add(LoaiSP);
                context.SaveChanges();
                ChuyendulieuLoai();
                frmQLSanPham_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
            
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                SANPHAM SP = new SANPHAM();
                SP.MASP = txtMaSP.Text;
                SP.TENSP = txtTenSP.Text;
                SP.MALOAI = cmbTLoai.SelectedValue.ToString();
                SP.NHASX = txtNhaSX.Text;
                SP.GIAMUA = int.Parse(txtGiaMua.Text);
                SP.GIABAN = int.Parse(txtGiaBan.Text);
                context.SANPHAMs.Add(SP);
                context.SaveChanges();
                ChuyendulieuLoai();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }


    }
    }