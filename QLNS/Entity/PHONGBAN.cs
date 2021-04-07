namespace QuanLyNhanSu.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONGBAN")]
    public partial class PHONGBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONGBAN()
        {
            NHANVIEN = new HashSet<NHANVIEN>();
        }

        [Key]
        [StringLength(10)]
        public string id_Pb { get; set; }

        [Required]
        [StringLength(50)]
        public string name_Pb { get; set; }

        public int sonv_Pb { get; set; }

        [StringLength(100)]
        public string mota_Pb { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIEN { get; set; }
    }
}
