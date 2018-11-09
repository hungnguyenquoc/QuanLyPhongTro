namespace QLPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            DatPhongs = new HashSet<DatPhong>();
        }

        [Key]
        public int idPhong { get; set; }

        [Required]
        [StringLength(100)]
        public string TenPhong { get; set; }

        public double GiaPhong { get; set; }

        public double DienTichPhong { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(11)]
        public string SoDT { get; set; }

        public int SoNguoiO { get; set; }

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(100)]
        public string TenKhuVuc { get; set; }

        [Required]
        [StringLength(500)]
        public string TienIch { get; set; }

        [Required]
        [StringLength(1000)]
        public string MoTa { get; set; }

        [MaxLength(1)]
        public byte[] HinhAnh { get; set; }

        public int idBoss { get; set; }

        public int idAD { get; set; }

        public int? idMaKV { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual ChuPhongTro ChuPhongTro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatPhong> DatPhongs { get; set; }

        public virtual KhuVuc KhuVuc { get; set; }
    }
}
