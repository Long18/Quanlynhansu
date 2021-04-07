namespace QuanLyNhanSu.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHECKLOG")]
    public partial class CHECKLOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Ngay { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Noidung { get; set; }
    }
}
