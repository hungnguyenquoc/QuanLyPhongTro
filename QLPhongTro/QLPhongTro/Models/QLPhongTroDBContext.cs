namespace QLPhongTro.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLPhongTroDBContext : DbContext
    {
        public QLPhongTroDBContext()
            : base("name=QLPhongTroDBContext1")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<ChuPhongTro> ChuPhongTroes { get; set; }
        public virtual DbSet<DatPhong> DatPhongs { get; set; }
        public virtual DbSet<KhuVuc> KhuVucs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TimOGhep> TimOGheps { get; set; }
        public virtual DbSet<TrangThaiPhong> TrangThaiPhongs { get; set; }
        public virtual DbSet<TVNguoiDung> TVNguoiDungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .HasMany(e => e.Phongs)
                .WithRequired(e => e.Admin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Admin>()
                .HasMany(e => e.TimOGheps)
                .WithRequired(e => e.Admin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChuPhongTro>()
                .HasMany(e => e.Phongs)
                .WithRequired(e => e.ChuPhongTro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChuPhongTro>()
                .HasMany(e => e.TrangThaiPhongs)
                .WithRequired(e => e.ChuPhongTro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DatPhong>()
                .HasMany(e => e.TrangThaiPhongs)
                .WithRequired(e => e.DatPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.SoDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .Property(e => e.GioiTinh)
                .IsFixedLength();

            modelBuilder.Entity<Phong>()
                .Property(e => e.TrangThai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.DatPhongs)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.Admins)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.ChuPhongTroes)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.TVNguoiDungs)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TVNguoiDung>()
                .HasMany(e => e.DatPhongs)
                .WithRequired(e => e.TVNguoiDung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TVNguoiDung>()
                .HasMany(e => e.TimOGheps)
                .WithRequired(e => e.TVNguoiDung)
                .WillCascadeOnDelete(false);
        }
    }
}
