using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QL_CAFE.Reporting;
using QL_CAFE.Models;

namespace QL_CAFE
{
    public partial class frmInHoaDon : Form
    {
        public string maHD;
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            HienThiHoaDon();
        }

        private void HienThiHoaDon()
        {
            using (var _dbContext = new QuanLyCaFe_DBContext())
            {
                string truyVanSQL = "select hd.MAHD, TENSP,GIABAN,ct.SOLUONG from HOADON hd, CHITIETHOADON ct, SANPHAM sp where hd.MAHD = ct.MAHD AND sp.MASP = ct.MASP";

                List<InHD> listHD = _dbContext.Database.SqlQuery<InHD>(truyVanSQL).ToList();

                listHD = listHD.Where(hd => hd.maHD.ToString() == maHD).ToList();
                this.reportHoaDon.LocalReport.ReportPath = "../../InHDReport.rdlc";
                var reportDataSource = new ReportDataSource("InHDDataSet", listHD);
                this.reportHoaDon.LocalReport.DataSources.Clear();
                this.reportHoaDon.LocalReport.DataSources.Add(reportDataSource);
                this.reportHoaDon.RefreshReport();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

