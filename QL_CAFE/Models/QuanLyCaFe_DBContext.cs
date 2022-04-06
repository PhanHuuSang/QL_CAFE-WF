using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QL_CAFE.Models
{
    public partial class QuanLyCaFe_DBContext : DbContext
    {
        public QuanLyCaFe_DBContext()
            : base("name=QuanLyCaFe_DBContext2")
        {
        }

        public virtual DbSet<BAN> BANs { get; set; }
        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHUVUC> KHUVUCs { get; set; }
        public virtual DbSet<LOAISP> LOAISPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BAN>()
                .Property(e => e.MABAN)
                .IsUnicode(false);

            modelBuilder.Entity<BAN>()
                .Property(e => e.MAKV)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADON>()
                .Property(e => e.MASP)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MABAN)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAKV)
                .IsUnicode(false);

            modelBuilder.Entity<KHUVUC>()
                .Property(e => e.MAKV)
                .IsUnicode(false);

            modelBuilder.Entity<LOAISP>()
                .Property(e => e.MALOAI)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MASP)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MALOAI)
                .IsUnicode(false);
        }
    }
}
