namespace QL_CAFE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        [Key]
        public int MAHD { get; set; }

        [StringLength(30)]
        public string MABAN { get; set; }

        [StringLength(30)]
        public string MAKV { get; set; }

        [StringLength(30)]
        public string TK { get; set; }

        public DateTime? NGAYLAP { get; set; }

        [StringLength(30)]
        public string TRANGTHAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        public virtual KHUVUC KHUVUC { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
