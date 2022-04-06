namespace QL_CAFE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            TAIKHOANs = new HashSet<TAIKHOAN>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string HOTEN { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        public int? NAMSINH { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(50)]
        public string TKNGANHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
    }
}
