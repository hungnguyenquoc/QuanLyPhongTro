namespace QLPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatPhong")]
    public partial class DatPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatPhong()
        {
            TrangThaiPhongs = new HashSet<TrangThaiPhong>();
        }

        [Key]
        public int idDatPhong { get; set; }

        public int idPhong { get; set; }

        public int idUser { get; set; }

        [Required]
        [StringLength(100)]
        public string TenPhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDangKy { get; set; }

        public virtual Phong Phong { get; set; }

        public virtual TVNguoiDung TVNguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrangThaiPhong> TrangThaiPhongs { get; set; }
    }
}
