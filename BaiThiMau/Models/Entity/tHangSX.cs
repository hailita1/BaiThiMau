namespace BaiThiMau.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tHangSX")]
    public partial class tHangSX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tHangSX()
        {
            tDanhMucSPs = new HashSet<tDanhMucSP>();
        }

        [Key]
        [StringLength(25)]
        public string MaHangSX { get; set; }

        [StringLength(100)]
        public string HangSX { get; set; }

        [StringLength(25)]
        public string MaNuocThuongHieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tDanhMucSP> tDanhMucSPs { get; set; }

        public virtual tQuocGia tQuocGia { get; set; }
    }
}
