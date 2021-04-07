namespace QuanLyNhanSu.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANGNHAP")]
    public partial class DANGNHAP
    {
        [Key]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(20)]
        public string password { get; set; }

        [Required]
        [StringLength(10)]
        public string id_Nv { get; set; }

        [StringLength(10)]
        public string chucvu { get; set; }

        [StringLength(50)]
        public string LichSu { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
