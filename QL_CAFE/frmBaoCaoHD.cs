using Microsoft.Reporting.WinForms;
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
   
    public partial class frmBaoCaoHD : Form
    {
        QuanLyCaFe_DBContext context = new QuanLyCaFe_DBContext();
        public frmBaoCaoHD()
        {
            InitializeComponent();
        }

        private void frmBaoCaoHD_Load(object sender, EventArgs e)
        {
            cbTatCa.Checked = true;
            ChuyenDuLieu();
            ChuyencmbTen();
        }

        private void ChuyencmbTen()
        {
            List<NHANVIEN> listNV = context.NHANVIENs.ToList();
            cmbNguoiLap.DataSource = listNV;
            cmbNguoiLap.DisplayMember = "HOTEN";
            cmbNguoiLap.ValueMember = "ID";
        }

        private void ChuyenDuLieu()
        {
           gdvHD.Rows.Clear();
            List<HOADON> listHD = new List<HOADON>();
            int sum = 0;
            if (cbTatCa.Checked == true)
                listHD = context.HOADONs.ToList();
            else
                listHD = context.HOADONs.Where(p => p.TAIKHOAN.NHANVIEN.HOTEN == cmbNguoiLap.Text ).ToList();
                foreach (HOADON item in listHD)
                {

                    int index = gdvHD.Rows.Add();
                    gdvHD.Rows[index].Cells[0].Value = (index + 1);
                    gdvHD.Rows[index].Cells[1].Value = item.MAHD;
                    gdvHD.Rows[index].Cells[2].Value = item.NGAYLAP;
                    gdvHD.Rows[index].Cells[3].Value = item.TAIKHOAN.NHANVIEN.HOTEN;
                    gdvHD.Rows[index].Cells[4].Value = item.CHITIETHOADONs.Sum(p => p.SOLUONG * p.SANPHAM.GIABAN);
                    sum += int.Parse((item.CHITIETHOADONs.Sum(p => p.SOLUONG * p.SANPHAM.GIABAN)).ToString());
                }
                btntongtien.Text = "Tổng Tiền: " + sum + " VND";
            }
            

            private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTatCa_Click(object sender, EventArgs e)
        {
            ChuyenDuLieu();
        }

        private void cmbNguoiLap_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTatCa.Checked = false;
            ChuyenDuLieu();
        }
    }
}

