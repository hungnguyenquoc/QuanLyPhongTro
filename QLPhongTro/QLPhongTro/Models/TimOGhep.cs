namespace QLPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimOGhep")]
    public partial class TimOGhep
    {
        [Key]
        public int idOGhep { get; set; }

        public int idUser { get; set; }

        public int idAD { get; set; }

        [Required]
        [StringLength(100)]
        public string TenUser { get; set; }

        public double GiaPhong { get; set; }

        [Required]
        [StringLength(200)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(10)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(500)]
        public string TienIch { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual TVNguoiDung TVNguoiDung { get; set; }
    }
}
