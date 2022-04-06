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
    public partial class frmMain : Form
    {

        QuanLyCaFe_DBContext context = new QuanLyCaFe_DBContext();
        string stk;
        HOADON HDHT;
        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer.Start();
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            SapXepButtonVao(btnHeThong, btnQuanLy, btnBaoCao, rong, rong, rong);
            KhoaChucNang();
            MoManHinhDangNhap();


        }


        private void ChuyenLoai()
        {
            List<LOAISP> listLoai = context.LOAISPs.ToList();
            cmbLoai.DataSource = listLoai;
            cmbLoai.DisplayMember = "TenLoai";
            cmbLoai.ValueMember = "MaLoai";
        }

        private void TaoBan()
        {

            int sb = 1;
            for (int i = 1; i <= 24; i++)
            {

                Button Ban = new Button();
                Ban.Name = "btnBan" + sb;
                Ban.Size = new Size(135, 80);
                Ban.Font = new Font("Times New Roman", 15f);
                Ban.Text = "Bàn " + sb;
                Ban.FlatAppearance.MouseOverBackColor = Color.Aqua;
                Ban.FlatStyle = FlatStyle.Flat;
                Ban.BackColor = Color.NavajoWhite;
                Ban.Click += Ban_Click;
                //Ban.Image = Image.FromFile("C:/Users/sangk/Desktop/Do An/Ban.png");
                flpBan.Controls.Add(Ban);

                if (context.BANs.Where(p => p.MABAN == sb.ToString()).Count() == 0)
                {
                    for (int kv = 1; kv <= context.KHUVUCs.Count(); kv++)
                    {
                        BAN dbBan = new BAN();
                        dbBan.MABAN = sb.ToString();
                        dbBan.TENBAN = "Bàn " + sb;
                        dbBan.MAKV = kv.ToString();
                        Ban.Click += Ban_Click;
                        context.BANs.Add(dbBan);
                        context.SaveChanges();
                    }
                }
                sb++;
            }
        }


        private string ChuyentenkhuT(string Khu)
        {
            if (Khu == "Sảnh")
                return "Khu 1";
            else if (Khu == "VIP")
                return "Khu 5";
            else
                return "Khu " + (int.Parse(TachSo(Khu)) + 1);
        }
        //private string ChuyentenkhuN(string Khu)
        //{
        //    if (Khu == "Khu 1")
        //        return "Sảnh";
        //    else if (Khu == "Khu 5")
        //        return "VIP";
        //    else
        //        return "Tầng " + (int.Parse(TachSo(Khu)) - 1);
        //}

        private void Ban_Click(Object sender, EventArgs e)
        {
            if ( btnKhuVuc.Text != "")
            {
                foreach (Button item in flpBan.Controls)
                        item.BackColor = Color.NavajoWhite;
                ((Button)sender).BackColor = Color.Fuchsia;
                btnBan.Text = ((Button)sender).Text;
                string ban = TachSo(btnBan.Text);
                string khuvuc = TachSo(btnKhuVuc.Text);
                HDHT = context.HOADONs.Where(k => k.MABAN == ban && k.MAKV == khuvuc && k.TRANGTHAI == "CHƯA THANH TOÁN").FirstOrDefault();
                ToMauBan(TachSo(btnKhuVuc.Text));
                try
                {
                    
                    btnSoHD.Text = "Hoá Đơn: " + HDHT.MAHD;
                    ChuyenDuLieuDGV();
                    btnTinhTrang.Text = HDHT.TRANGTHAI;
                }
                catch
                {
                    btnSoHD.Text = "Bàn Trống";
                    btnTinhTrang.Text = "CHƯA THANH TOÁN";
                    btnTongTien.Text = "Thành Tiền: 0 VND";
                    dgvSanPham.Rows.Clear();
                }

            }
        }

        private void TaoKV()
        {

            int X = 18, Y = 10;
            int sb = 1;
            for (int i = 1; i <= 5; i++)
            {


                Button KV = new Button();
                KV.Location = new Point(X, Y);
                KV.Name = "btnKV" + sb;
                KV.Size = new Size(135, 35);
                KV.FlatAppearance.MouseOverBackColor = Color.Aqua;
                KV.FlatStyle = FlatStyle.Flat;
                KV.Font = new Font("Times New Roman", 20f);
                if (i == 1)
                    KV.Text = "Sảnh";
                else if (i == 5)
                    KV.Text = "VIP";
                else
                    KV.Text = "Tầng " + (sb - 1);
                // KV.Image = Image.FromFile("C:/Users/sangk/Desktop/Do An/Ban.png");
                KV.BackColor = Color.NavajoWhite;
                KV.Click += KhuVuc_Click;
                pnlKhu.Controls.Add(KV);
                if (context.KHUVUCs.Where(p => p.MAKV == sb.ToString()).Count() == 0)
                {
                    KHUVUC dbKV = new KHUVUC();
                    dbKV.MAKV = sb.ToString();
                    dbKV.TENKV = "Khu Vực " + sb;
                    context.KHUVUCs.Add(dbKV);
                    context.SaveChanges();

                }
                X = X + 179;
                sb++;

            }

        }



        private void KhuVuc_Click(Object sender, EventArgs e)
        {
            btnBan.Text = "";
            btnSoHD.Text = "";
            
            foreach (Button B in flpBan.Controls)
            {
                B.BackColor = Color.NavajoWhite;
            }
            dgvSanPham.Rows.Clear();
            btnThanhToan.Text = "THANH TOÁN";
            btnTinhTrang.Text = "TÌNH TRẠNG";
            foreach (Button K in pnlKhu.Controls)
                K.BackColor = Color.NavajoWhite;
            if (((Button)sender).BackColor == Color.NavajoWhite)
            {
                btnKhuVuc.Text = ChuyentenkhuT(((Button)sender).Text);
                ((Button)sender).BackColor = Color.Fuchsia;
            }
            else
            {
                btnKhuVuc.Text = "";
                ((Button)sender).BackColor = Color.NavajoWhite;
            }
            ToMauBan(TachSo(btnKhuVuc.Text));
        }


        private void KhoaChucNang()
        {
            btnTenNV.Text = "";
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;
            btnTaiKhoan.Enabled = false;
            btnQuanLy.Enabled = false;
            btnBaoCao.Enabled = false;

        }
        private void MoManHinhDangNhap()
        {
            string frmName = "frmDangNhap";
            if (!KiemTraManHinh(frmName))
            {
                frmDangNhap frmmhDangNhap = new frmDangNhap();
                frmmhDangNhap.StartPosition = FormStartPosition.CenterScreen;
                frmmhDangNhap.chungThucThongTinTaiKhoan += FrmDangNhap_chungThucThongTinTaiKhoan;
                frmmhDangNhap.ShowDialog();
            }

        }
        private bool KiemTraManHinh(string frmName)
        {
            if (this.MdiChildren.Any(p => p.Name == frmName))
            {
                return true;
            }
            else
                return false;

        }

        private void FrmDangNhap_chungThucThongTinTaiKhoan(object sender)
        {
            stk = sender.ToString();
            TAIKHOAN TK = context.TAIKHOANs.Where(t => t.TK == stk).FirstOrDefault();
            MoChucNang();
            btnTenNV.Text = TK.QUYEN + ": " + TK.NHANVIEN.HOTEN;
            ChuyenLoai();
            cmbLoai.Text = "";
            btnKhuVuc.Text = "";
            btnBan.Text = "";
            cmbSanPham.Text = "";
            TaoKV();
            TaoBan();

            if (TK.QUYEN == "Quản Lý")
                btnNhanVien.Enabled = true;
            else
                btnNhanVien.Enabled = false;


        }

        private void MoChucNang()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnTaiKhoan.Enabled = true;
            btnQuanLy.Enabled = true;
            btnBaoCao.Enabled = true;
        }

        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoai.Text == "")
            {
                cmbSanPham.DataSource = context.SANPHAMs.ToList();
                cmbSanPham.DisplayMember = "TENSP";
                cmbSanPham.ValueMember = "MASP";
            }
            else
            {
                string ma = cmbLoai.SelectedValue.ToString();
                cmbSanPham.DataSource = context.SANPHAMs.Where(p => p.MALOAI == ma).ToList();
                cmbSanPham.DisplayMember = "TENSP";
                cmbSanPham.ValueMember = "MASP";
            }

        }

        private void ChuyenDuLieuDGV()
        {
            btnTongTien.Text = "Thành Tiền: 0 VND";
            dgvSanPham.Rows.Clear();
            List<CHITIETHOADON> listHD = context.CHITIETHOADONs.Where(dv => dv.MAHD == HDHT.MAHD).ToList();
            foreach (CHITIETHOADON item in listHD)
            {
                int index = dgvSanPham.Rows.Add();
                dgvSanPham.Rows[index].Cells[0].Value = (index + 1);
                dgvSanPham.Rows[index].Cells[1].Value = item.SANPHAM.TENSP;
                dgvSanPham.Rows[index].Cells[2].Value = item.SOLUONG;
                dgvSanPham.Rows[index].Cells[3].Value = item.SANPHAM.GIABAN + " " + item.DONVI;
                dgvSanPham.Rows[index].Cells[4].Value = item.SOLUONG * item.SANPHAM.GIABAN;
                btnTinhTrang.Text = item.HOADON.TRANGTHAI;
                btnTongTien.Text = "Thành Tiền: " + listHD.Sum(p => (p.SOLUONG * p.SANPHAM.GIABAN)).ToString() + " VND";            
            }
            
            

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnTinhTrang.Text == "ĐÃ THANH TOÁN")
                MessageBox.Show("Bàn Đã Được Thanh Toán, Không thể Thêm", "Chú Ý", MessageBoxButtons.OK);
            else
                try
                {
                    CHITIETHOADON CTHD = context.CHITIETHOADONs.Where(p => p.MAHD == HDHT.MAHD && p.MASP == cmbSanPham.SelectedValue.ToString()).FirstOrDefault();
                    if (CTHD != null)
                    {

                        CTHD.SOLUONG += int.Parse(txtSoLuong.Text);
                        context.SaveChanges();
                        ChuyenDuLieuDGV();

                    }
                    else
                    {
                        CHITIETHOADON CTHDM = new CHITIETHOADON();
                        CTHDM.MASP = cmbSanPham.SelectedValue.ToString();
                        CTHDM.MAHD = HDHT.MAHD;
                        CTHDM.SOLUONG = int.Parse(txtSoLuong.Text);
                        CTHDM.DONVI = "VND";
                        context.CHITIETHOADONs.Add(CTHDM);
                        context.SaveChanges();
                        ChuyenDuLieuDGV();
                    }
                }
                catch
                {
                    if (btnSoHD.Text == "" || btnSoHD.Text == "Bàn Trống")
                        MessageBox.Show("Vui lòng tạo bàn trước khi thêm", "Chú Ý", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Vui lòng chọn món hoặc số lượng để thêm", "Chú Ý", MessageBoxButtons.OK);
                }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (btnTinhTrang.Text == "ĐÃ THANH TOÁN")
                MessageBox.Show("Bàn Đã Được Thanh Toán, Không thể Xoá", "Chú Ý", MessageBoxButtons.OK);
            else
                try
                {
                    CHITIETHOADON CTHD = context.CHITIETHOADONs.Where(p => p.MAHD == HDHT.MAHD && p.MASP == cmbSanPham.SelectedValue.ToString()).FirstOrDefault();
                    context.CHITIETHOADONs.Remove(CTHD);
                    context.SaveChanges();
                    ChuyenDuLieuDGV();
                }
                catch
                {
                    if (btnSoHD.Text == "" || btnSoHD.Text == "Bàn Trống" || dgvSanPham.Rows.Count == 0)
                        MessageBox.Show("Xoá Không Thành Công", "Chú Ý", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Vui lòng chọn món để xoá", "Chú Ý", MessageBoxButtons.OK);
                }



        }

        private string TachSo(string kt)
        {
            int a;
            string s = "";
            for (int i = 0; i < kt.Length; i++)
            {
                if (int.TryParse(kt[i].ToString(), out a) == true)
                {
                    s = s + a.ToString();
                }
            }
            return s;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            VeManHinhChinh();
            DiChuyenControl(sender);
            MoManHinhDangNhap();

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            VeManHinhChinh();
            DiChuyenControl(sender);
            KhoaChucNang();
        }


        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (btnTinhTrang.Text == "ĐÃ THANH TOÁN")
                MessageBox.Show("Bàn Đã Được Thanh Toán", "Chú Ý", MessageBoxButtons.OK);
            else
                try
                {
                    
                    var ms = MessageBox.Show("Bạn có muốn thanh toán bàn này", "Thông báo", MessageBoxButtons.YesNo);
                    if (ms == DialogResult.Yes)
                    {
                        HOADON HD = context.HOADONs.Where(p => p.MAHD == HDHT.MAHD).FirstOrDefault();
                        HD.TRANGTHAI = "ĐÃ THANH TOÁN";
                        context.SaveChanges();
                        btnTinhTrang.Text = HD.TRANGTHAI;
                        foreach(Button item in flpBan.Controls)
                        {
                            if(item.Text == btnBan.Text)
                                item.BackColor = Color.Fuchsia;
                        }    
                    }
                }
                catch
                {
                    
                    
                    if (btnSoHD.Text == "")
                        MessageBox.Show("Vui lòng chọn bàn", "Thông báo", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Bàn này chưa có người đặt", "Thông báo", MessageBoxButtons.OK);
                }
     


        }


        private void DiChuyenControl(object vtPN)
        {
            pnlControlVang.BackColor = Color.Pink;
            pnlControlVang.Top = ((Button)vtPN).Top;
        }

        private void SapXepButtonVao(Button b1, Button b2, Button b3, Button b4, Button b5, Button b6)
        {
            b1.Location = panels1.Location;
            b2.Location = panels2.Location;
            b3.Location = panels3.Location;
            b4.Location = panels4.Location;
            b5.Location = panels5.Location;
            b6.Location = panels6.Location;
        }
        private void SapXepButtonRa()
        {
            btnDangNhap.Location = panels7.Location;
            btnDangXuat.Location = panels7.Location;
            btnNhanVien.Location = panels7.Location;
            btnTaiKhoan.Location = panels7.Location;
            btnQuanCaFe.Location = panels7.Location;
            btnSanPham.Location = panels7.Location;
            btnHoaDon.Location = panels7.Location;
            btnThuNhap.Location = panels7.Location;
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            if (btnHeThong.BackColor == Color.Pink)
            {

                SapXepButtonRa();
                SapXepButtonVao(btnHeThong, btnDangNhap, btnTaiKhoan, btnDangXuat, btnQuanLy, btnBaoCao);
                btnHeThong.BackColor = Color.HotPink;
                btnBaoCao.BackColor = Color.Pink;
                btnQuanLy.BackColor = Color.Pink;
            }
            else
            {
                SapXepButtonRa();
                SapXepButtonVao(btnHeThong, btnQuanLy, btnBaoCao, rong, rong, rong);

                btnHeThong.BackColor = Color.Pink;
            }
            DiChuyenControl(sender);
        }


        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            if (btnQuanLy.BackColor == Color.Pink)
            {
                SapXepButtonRa();
                SapXepButtonVao(btnHeThong, btnQuanLy, btnQuanCaFe, btnNhanVien,btnSanPham, btnBaoCao);
                btnQuanLy.BackColor = Color.HotPink;
                btnHeThong.BackColor = Color.Pink;
                btnBaoCao.BackColor = Color.Pink;
            }
            else
            {
                SapXepButtonRa();
                SapXepButtonVao(btnHeThong, btnQuanLy, btnBaoCao, rong, rong, rong);
                btnQuanLy.BackColor = Color.Pink;
            }
            DiChuyenControl(sender);

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

            if (btnBaoCao.BackColor == Color.Pink)
            {

                SapXepButtonRa();
                SapXepButtonVao(btnHeThong, btnQuanLy, btnBaoCao, btnHoaDon, btnThuNhap, rong);
                btnBaoCao.BackColor = Color.HotPink;
                btnHeThong.BackColor = Color.Pink;
                btnQuanLy.BackColor = Color.Pink;
            }
            else
            {
                SapXepButtonRa();
                btnBaoCao.BackColor = Color.Pink;
            }
            DiChuyenControl(sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (btnHome.BackColor == Color.Silver)
            {
                pnlMenu.Show();
                btnHome.BackColor = Color.Violet;
            }
            else
            {
                if (btnHome.BackColor == Color.Violet)
                {
                    pnlMenu.Hide();
                    btnHome.BackColor = Color.Silver;
                }
            }

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            VeManHinhChinh();
            DiChuyenControl(sender);
            frmThongTinTaiKhoan frmTTTK = new frmThongTinTaiKhoan();
            frmTTTK.STK = stk;
            frmTTTK.ShowDialog();
        }

        private void VeManHinhChinh()
        {
            btnSoHD.Text = "";
            btnKhuVuc.Text = "";
            btnBan.Text = "";
            btnTongTien.Text = "Thành Tiền";
            btnTinhTrang.Text = "TÌNH TRẠNG";
            pnlBan.Hide();
            pnlManHinhChinh.Show();
            dgvSanPham.Rows.Clear();

        }

        private void btnBanCaFe_Click(object sender, EventArgs e)
        {
            DiChuyenControl(sender);
            pnlManHinhChinh.Hide();
            pnlBan.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            VeManHinhChinh();
            frmQuanLyNhanVien QLNV = new frmQuanLyNhanVien();
            QLNV.STK = stk;
            DiChuyenControl(sender);
            QLNV.Show();

        }

        private void btnLuongNV_Click(object sender, EventArgs e)
        {
            DiChuyenControl(sender);
        }

        private void btnThuNhap_Click(object sender, EventArgs e)
        {
            DiChuyenControl(sender);
        }

        private void MayIn_Click(object sender, EventArgs e)
        {
            try
            {
                frmInHoaDon InHoaDon = new frmInHoaDon();
                InHoaDon.maHD = HDHT.MAHD.ToString();
                InHoaDon.Show();
            }
            catch
            {
                MessageBox.Show("Không có hoá đơn để in");
            }
        }

        private void dgvSanPham_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbSanPham.Text = dgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();

        }


        private void ToMauBan(string khu)
        {
            List<HOADON> listHD = context.HOADONs.Where(k => k.MAKV == khu).ToList();
            foreach(HOADON item in listHD)
            {
                foreach(Button ban in flpBan.Controls)
                { string so = TachSo(ban.Text);
                    if (item.TRANGTHAI == "CHƯA THANH TOÁN" && item.MABAN == so)
                    {
                        ban.BackColor = Color.Red;
                    }   
                }    
                
            }    
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnTinhTrang.Text == "ĐÃ THANH TOÁN")
                MessageBox.Show("Bàn Đã Được Thanh Toán, Không thể Sửa", "Chú Ý", MessageBoxButtons.OK);
            else
                try
                {
                        context.CHITIETHOADONs.Where(ct => ct.MAHD == HDHT.MAHD && ct.MASP == cmbSanPham.SelectedValue.ToString()).FirstOrDefault().SOLUONG = int.Parse(txtSoLuong.Text);
                        context.SaveChanges();
                        ChuyenDuLieuDGV();  
                }
                catch
                {
                    if (btnSoHD.Text == "" || btnSoHD.Text == "Bàn Trống")
                        MessageBox.Show("Vui lòng tạo bàn trước khi sửa", "Chú Ý", MessageBoxButtons.OK);
                    else if(dgvSanPham.Rows.Count == 0)
                        MessageBox.Show("Không còn món nào", "Chú Ý", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Vui lòng chọn món hoặc số lượng đúng, để sửa", "Chú Ý", MessageBoxButtons.OK);
                }

        }

        private void btnTaoBan_Click(object sender, EventArgs e)
        {

            if (btnSoHD.Text == "Bàn Trống")
            {
                btnTongTien.Text = "Thành Tiền: 0 VND";
                HOADON dbHD = new HOADON();
                dbHD.MAKV = TachSo(btnKhuVuc.Text);
                dbHD.MABAN = TachSo(btnBan.Text);
                dbHD.NGAYLAP = DateTime.Now;
                dbHD.TRANGTHAI = "CHƯA THANH TOÁN";
                dbHD.TK = stk;
                context.HOADONs.Add(dbHD);
                context.SaveChanges();
                HDHT = context.HOADONs.Where(k => k.MABAN == dbHD.MABAN && k.MAKV == dbHD.MAKV && k.TRANGTHAI == "CHƯA THANH TOÁN").FirstOrDefault();
                btnSoHD.Text = "Hoá Đơn: " + HDHT.MAHD;
                ToMauBan(TachSo(btnKhuVuc.Text));
            }
            else if (btnBan.Text == "")
                MessageBox.Show("Vui lòng chọn bàn để tạo", "Thông Báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Bàn đang có khách", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            VeManHinhChinh();
            DiChuyenControl(sender);
            frmBaoCaoHD bchd= new frmBaoCaoHD();
            bchd.ShowDialog();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            VeManHinhChinh();
            frmQLSanPham QLSP = new frmQLSanPham();
            DiChuyenControl(sender);
            QLSP.Show();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.btnTime.Text = string.Format("DATE: {0} \n  {1}",DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:tt"));
        }


    }

        ///PNL
        ///SK
    }
 
