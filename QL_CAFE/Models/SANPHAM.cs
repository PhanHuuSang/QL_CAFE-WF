namespace QL_CAFE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        [Key]
        [StringLength(30)]
        public string MASP { get; set; }

        [StringLength(50)]
        public string TENSP { get; set; }

        [StringLength(30)]
        public string MALOAI { get; set; }

        [StringLength(30)]
        public string NHASX { get; set; }

        public int? GIAMUA { get; set; }

        public int? GIABAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        public virtual LOAISP LOAISP { get; set; }
    }
}
