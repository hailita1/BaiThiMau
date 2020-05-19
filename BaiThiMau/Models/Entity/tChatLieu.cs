namespace BaiThiMau.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tChatLieu")]
    public partial class tChatLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tChatLieu()
        {
            tDanhMucSPs = new HashSet<tDanhMucSP>();
        }

        [Key]
        [StringLength(25)]
        public string MaChatLieu { get; set; }

        [StringLength(150)]
        public string ChatLieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tDanhMucSP> tDanhMucSPs { get; set; }
    }
}
