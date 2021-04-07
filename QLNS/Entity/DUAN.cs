namespace QuanLyNhanSu.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DUAN")]
    public partial class DUAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DUAN()
        {
            NHANVIEN = new HashSet<NHANVIEN>();
        }

        [Key]
        [StringLength(10)]
        public string id_Da { get; set; }

        [Required]
        [StringLength(50)]
        public string name_Da { get; set; }

        public int sonv_Da { get; set; }

        [Required]
        [StringLength(100)]
        public string mota_Da { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIEN { get; set; }
    }
}
