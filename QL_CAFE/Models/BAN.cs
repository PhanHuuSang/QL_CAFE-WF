namespace QL_CAFE.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAN")]
    public partial class BAN
    {
        [Key]
        public int STT { get; set; }

        [StringLength(30)]
        public string MABAN { get; set; }

        [StringLength(50)]
        public string TENBAN { get; set; }

        [StringLength(30)]
        public string MAKV { get; set; }

        public virtual KHUVUC KHUVUC { get; set; }
    }
}
