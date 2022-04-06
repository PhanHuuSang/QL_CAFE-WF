namespace QL_CAFE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADON")]
    public partial class CHITIETHOADON
    {
        [Key]
        public int STT { get; set; }

        [StringLength(30)]
        public string MASP { get; set; }

        public int? MAHD { get; set; }

        public int? SOLUONG { get; set; }

        [StringLength(20)]
        public string DONVI { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
