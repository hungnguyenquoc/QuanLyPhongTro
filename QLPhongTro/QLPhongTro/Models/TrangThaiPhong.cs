namespace QLPhongTro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrangThaiPhong")]
    public partial class TrangThaiPhong
    {
        [Key]
        [StringLength(20)]
        public string TinhTrang { get; set; }

        public int idDatPhong { get; set; }

        public int idBoss { get; set; }

        public virtual ChuPhongTro ChuPhongTro { get; set; }

        public virtual DatPhong DatPhong { get; set; }
    }
}
