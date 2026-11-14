using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Website.Models
{
    public partial class KiTucXaDataBaseContext : DbContext
    {
        public KiTucXaDataBaseContext()
        {
        }

        public KiTucXaDataBaseContext(DbContextOptions<KiTucXaDataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<DichVu> DichVus { get; set; } = null!;
        public virtual DbSet<DichVuPhong> DichVuPhongs { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HopDong> HopDongs { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<LoiPham> LoiPhams { get; set; } = null!;
        public virtual DbSet<Nha> Nhas { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<Phong> Phongs { get; set; } = null!;
        public virtual DbSet<PhuongXa> PhuongXas { get; set; } = null!;
        public virtual DbSet<QuanHuyen> QuanHuyens { get; set; } = null!;
        public virtual DbSet<SuaChua> SuaChuas { get; set; } = null!;
        public virtual DbSet<ThanhPho> ThanhPhos { get; set; } = null!;
        public virtual DbSet<ThanhVienPhong> ThanhVienPhongs { get; set; } = null!;
        public virtual DbSet<TheKiTucXa> TheKiTucXas { get; set; } = null!;
        public virtual DbSet<TheSinhVien> TheSinhViens { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.ToTable("ChiTietHoaDon");

                entity.Property(e => e.MaDv).HasColumnName("MaDV");

                entity.Property(e => e.ThanhTien).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MaDvNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaDv)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ChiTietHoaDon_DichVu");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ChiTietHoaDon_HoaDon");

                entity.HasOne(d => d.MaLoiNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaLoi)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ChiTietHoaDon_LoiPham");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contacts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.FullName)
                    .HasMaxLength(250)
                    .HasColumnName("full_name");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(20)
                    .HasColumnName("ip_address");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<DichVu>(entity =>
            {
                entity.ToTable("DichVu");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.LoaiDv).HasColumnName("LoaiDV");

                entity.Property(e => e.TenDv)
                    .HasMaxLength(250)
                    .HasColumnName("TenDV");
            });

            modelBuilder.Entity<DichVuPhong>(entity =>
            {
                entity.ToTable("DichVuPhong");

                entity.Property(e => e.MaDv).HasColumnName("MaDV");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.DichVuPhongs)
                    .HasForeignKey(d => d.MaPhong)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DichVuPhong_Phong");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.ToTable("HoaDon");

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.HanDong).HasColumnType("datetime");

                entity.Property(e => e.NgayDongTien).HasColumnType("datetime");

                entity.Property(e => e.NguoiDong).HasMaxLength(250);

                entity.Property(e => e.TienDong).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TongTien).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MaHopDongNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaHopDong)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HoaDon_HopDong");
            });

            modelBuilder.Entity<HopDong>(entity =>
            {
                entity.ToTable("HopDong");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");

                entity.Property(e => e.TienCoc).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HopDongs)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HoaDon_KhachHang");

                entity.HasOne(d => d.MaNvNavigation)
                    .WithMany(p => p.HopDongs)
                    .HasForeignKey(d => d.MaNv)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HoaDon_NhanVien");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.HopDongs)
                    .HasForeignKey(d => d.MaPhong)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HoaDon_Phong");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.ToTable("KhachHang");

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CMND");

                entity.Property(e => e.DiaChi).HasMaxLength(250);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinh).HasMaxLength(50);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TenKh)
                    .HasMaxLength(250)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<LoiPham>(entity =>
            {
                entity.ToTable("LoiPham");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.TenLoi).HasMaxLength(50);

                entity.Property(e => e.TienPhat).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Nha>(entity =>
            {
                entity.ToTable("Nha");

                entity.Property(e => e.DiaChi).HasMaxLength(250);

                entity.Property(e => e.MaPx).HasColumnName("MaPX");

                entity.Property(e => e.MaQh).HasColumnName("MaQH");

                entity.Property(e => e.MaTp).HasColumnName("MaTP");

                entity.Property(e => e.Slphong).HasColumnName("SLPhong");

                entity.Property(e => e.TenNha).HasMaxLength(250);

                entity.HasOne(d => d.MaPxNavigation)
                    .WithMany(p => p.Nhas)
                    .HasForeignKey(d => d.MaPx)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Nha_PhuongXa");

                entity.HasOne(d => d.MaQhNavigation)
                    .WithMany(p => p.Nhas)
                    .HasForeignKey(d => d.MaQh)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Nha_QuanHuyen");

                entity.HasOne(d => d.MaTpNavigation)
                    .WithMany(p => p.Nhas)
                    .HasForeignKey(d => d.MaTp)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Nha_ThanhPho");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.ToTable("NhanVien");

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CMND");

                entity.Property(e => e.DiaChi).HasMaxLength(500);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GioiTinh).HasMaxLength(50);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TenNv)
                    .HasMaxLength(250)
                    .HasColumnName("TenNV");
            });

            modelBuilder.Entity<Phong>(entity =>
            {
                entity.ToTable("Phong");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SlnguoiMax).HasColumnName("SLNguoiMax");

                entity.Property(e => e.TenPhong).HasMaxLength(250);

                entity.HasOne(d => d.MaNhaNavigation)
                    .WithMany(p => p.Phongs)
                    .HasForeignKey(d => d.MaNha)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Phong_Nha");
            });

            modelBuilder.Entity<PhuongXa>(entity =>
            {
                entity.ToTable("PhuongXa");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.MaQh).HasColumnName("MaQH");

                entity.Property(e => e.Ten).HasMaxLength(250);
            });

            modelBuilder.Entity<QuanHuyen>(entity =>
            {
                entity.ToTable("QuanHuyen");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.GhiChu)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MaTp).HasColumnName("MaTP");

                entity.Property(e => e.Ten).HasMaxLength(250);
            });

            modelBuilder.Entity<SuaChua>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SuaChua");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.NgayTao).HasColumnType("datetime");
            });

            modelBuilder.Entity<ThanhPho>(entity =>
            {
                entity.ToTable("ThanhPho");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.Ten).HasMaxLength(250);
            });

            modelBuilder.Entity<ThanhVienPhong>(entity =>
            {
                entity.ToTable("ThanhVienPhong");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.ThanhVienPhongs)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ThanhVienPhong_KhachHang");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.ThanhVienPhongs)
                    .HasForeignKey(d => d.MaPhong)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ThanhVienPhong_Phong");
            });

            modelBuilder.Entity<TheKiTucXa>(entity =>
            {
                entity.ToTable("TheKiTucXa");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MaThe)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");

                entity.Property(e => e.NgayTao).HasColumnType("datetime");
            });

            modelBuilder.Entity<TheSinhVien>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TheSinhVien");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MaThe)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHetHan).HasColumnType("datetime");

                entity.Property(e => e.NgayTaoThe).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
