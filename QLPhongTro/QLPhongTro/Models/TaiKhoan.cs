namespace QLPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            Admins = new HashSet<Admin>();
            ChuPhongTroes = new HashSet<ChuPhongTro>();
            TVNguoiDungs = new HashSet<TVNguoiDung>();
        }

        [Key]
        [StringLength(100)]
        public string TenTaiKhoan { get; set; }

        [Required]
        [StringLength(100)]
        public string TenHienThi { get; set; }

        [Required]
        [StringLength(1000)]
        public string MatKhau { get; set; }

        public int KieuNguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Admin> Admins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuPhongTro> ChuPhongTroes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TVNguoiDung> TVNguoiDungs { get; set; }
    }
}
