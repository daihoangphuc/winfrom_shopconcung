using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Form_ShopConCung
{
	public partial class DBContext : DbContext
	{
		public DBContext()
			: base("name=SPContext")
		{
		}

		public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
		public virtual DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
		public virtual DbSet<DonHang> DonHangs { get; set; }
		public virtual DbSet<KhachHang> KhachHangs { get; set; }
		public virtual DbSet<NhanVien> NhanViens { get; set; }
		public virtual DbSet<SanPham> SanPhams { get; set; }
		public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
		public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ChiTietDonHang>()
				.Property(e => e.MaChiTietDonHang)
				.IsUnicode(false);

			modelBuilder.Entity<ChiTietDonHang>()
				.Property(e => e.MaDonHang)
				.IsUnicode(false);

			modelBuilder.Entity<ChiTietDonHang>()
				.Property(e => e.MaSanPham)
				.IsUnicode(false);

			modelBuilder.Entity<DanhMucSanPham>()
				.Property(e => e.MaDanhMuc)
				.IsUnicode(false);

			modelBuilder.Entity<DonHang>()
				.Property(e => e.MaDonHang)
				.IsUnicode(false);

			modelBuilder.Entity<DonHang>()
				.Property(e => e.MaKhachHang)
				.IsUnicode(false);

			modelBuilder.Entity<KhachHang>()
				.Property(e => e.MaKhachHang)
				.IsUnicode(false);

			modelBuilder.Entity<KhachHang>()
				.Property(e => e.SDT)
				.IsUnicode(false);

			modelBuilder.Entity<NhanVien>()
				.Property(e => e.MaNhanVien)
				.IsUnicode(false);

			modelBuilder.Entity<NhanVien>()
				.Property(e => e.ChucVu)
				.IsUnicode(false);

			modelBuilder.Entity<NhanVien>()
				.Property(e => e.SDT)
				.IsUnicode(false);

			modelBuilder.Entity<SanPham>()
				.Property(e => e.MaSanPham)
				.IsUnicode(false);

			modelBuilder.Entity<SanPham>()
				.Property(e => e.MaDanhMuc)
				.IsUnicode(false);

			modelBuilder.Entity<TaiKhoan>()
				.Property(e => e.idtaikhoan)
				.IsUnicode(false);

			modelBuilder.Entity<TaiKhoan>()
				.Property(e => e.matkhau)
				.IsUnicode(false);

			modelBuilder.Entity<TaiKhoan>()
				.Property(e => e.MaNhanVien)
				.IsUnicode(false);

			modelBuilder.Entity<TaiKhoan>()
				.Property(e => e.MaKhachHang)
				.IsUnicode(false);
		}
	}
}
