namespace BaiThiMau.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tKichThuoc")]
    public partial class tKichThuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tKichThuoc()
        {
            tDanhMucSPs = new HashSet<tDanhMucSP>();
        }

        [Key]
        [StringLength(25)]
        public string MaKichThuoc { get; set; }

        [StringLength(150)]
        public string KichThuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tDanhMucSP> tDanhMucSPs { get; set; }
    }
}
