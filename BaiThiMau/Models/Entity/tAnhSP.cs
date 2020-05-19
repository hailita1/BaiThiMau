namespace BaiThiMau.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tAnhSP")]
    public partial class tAnhSP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string MaSP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string TenFileAnh { get; set; }

        public short? ViTri { get; set; }

        public virtual tDanhMucSP tDanhMucSP { get; set; }
    }
}
