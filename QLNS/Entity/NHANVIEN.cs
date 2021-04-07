namespace QuanLyNhanSu.Entity
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
            DANGNHAP = new HashSet<DANGNHAP>();
        }

        [Key]
        [StringLength(10)]
        public string id_Nv { get; set; }

        [Required]
        [StringLength(100)]
        public string name_Nv { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaysinh_Nv { get; set; }

        [Required]
        [StringLength(50)]
        public string diachi_Nv { get; set; }

        public int luong_Nv { get; set; }

        [Required]
        [StringLength(10)]
        public string id_Pb { get; set; }

        [Required]
        [StringLength(10)]
        public string id_Da { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANGNHAP> DANGNHAP { get; set; }

        public virtual DUAN DUAN { get; set; }

        public virtual PHONGBAN PHONGBAN { get; set; }
    }
}
