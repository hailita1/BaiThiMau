namespace BaiThiMau.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tDanhMucSP")]
    public partial class tDanhMucSP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tDanhMucSP()
        {
            tAnhSPs = new HashSet<tAnhSP>();
        }

        [Key]
        [StringLength(25)]
        public string MaSP { get; set; }

        [StringLength(150)]
        public string TenSP { get; set; }

        [StringLength(25)]
        public string MaChatLieu { get; set; }

        [StringLength(55)]
        public string NganLapTop { get; set; }

        [StringLength(55)]
        public string Model { get; set; }

        [StringLength(55)]
        public string MauSac { get; set; }

        [StringLength(25)]
        public string MaKichThuoc { get; set; }

        public double? CanNang { get; set; }

        public double? DoNoi { get; set; }

        [StringLength(25)]
        public string MaHangSX { get; set; }

        [StringLength(25)]
        public string MaNuocSX { get; set; }

        [StringLength(25)]
        public string MaDacTinh { get; set; }

        [StringLength(155)]
        public string Website { get; set; }

        public double? ThoiGianBaoHanh { get; set; }

        [StringLength(255)]
        public string GioiThieuSP { get; set; }

        public double? Gia { get; set; }

        public double? ChietKhau { get; set; }

        [StringLength(25)]
        public string MaLoai { get; set; }

        [StringLength(25)]
        public string MaDT { get; set; }

        [StringLength(100)]
        public string Anh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tAnhSP> tAnhSPs { get; set; }

        public virtual tChatLieu tChatLieu { get; set; }

        public virtual tHangSX tHangSX { get; set; }

        public virtual tKichThuoc tKichThuoc { get; set; }

        public virtual tLoaiDT tLoaiDT { get; set; }

        public virtual tLoaiSP tLoaiSP { get; set; }

        public virtual tQuocGia tQuocGia { get; set; }
    }
}
