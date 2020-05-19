namespace BaiThiMau.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tQuocGia")]
    public partial class tQuocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tQuocGia()
        {
            tDanhMucSPs = new HashSet<tDanhMucSP>();
            tHangSXes = new HashSet<tHangSX>();
        }

        [Key]
        [StringLength(25)]
        public string MaNuoc { get; set; }

        [StringLength(100)]
        public string TenNuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tDanhMucSP> tDanhMucSPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tHangSX> tHangSXes { get; set; }
    }
}
