using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyNhanSu.Entity
{
	public partial class ModelQLNS : DbContext
	{
		public ModelQLNS()
			: base("name=ModelQLNS")
		{
		}

		public virtual DbSet<DANGNHAP> DANGNHAP { get; set; }
		public virtual DbSet<DUAN> DUAN { get; set; }
		public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
		public virtual DbSet<PHONGBAN> PHONGBAN { get; set; }
		public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
		public virtual DbSet<CHECKLOG> CHECKLOG { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<DANGNHAP>()
				.Property(e => e.username)
				.IsFixedLength();

			modelBuilder.Entity<DANGNHAP>()
				.Property(e => e.id_Nv)
				.IsFixedLength();

			modelBuilder.Entity<DANGNHAP>()
				.Property(e => e.chucvu)
				.IsFixedLength();

			modelBuilder.Entity<DUAN>()
				.Property(e => e.id_Da)
				.IsFixedLength();

			modelBuilder.Entity<DUAN>()
				.HasMany(e => e.NHANVIEN)
				.WithRequired(e => e.DUAN)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<NHANVIEN>()
				.Property(e => e.id_Nv)
				.IsFixedLength();

			modelBuilder.Entity<NHANVIEN>()
				.Property(e => e.id_Pb)
				.IsFixedLength();

			modelBuilder.Entity<NHANVIEN>()
				.Property(e => e.id_Da)
				.IsFixedLength();

			modelBuilder.Entity<NHANVIEN>()
				.HasMany(e => e.DANGNHAP)
				.WithRequired(e => e.NHANVIEN)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<PHONGBAN>()
				.Property(e => e.id_Pb)
				.IsFixedLength();

			modelBuilder.Entity<PHONGBAN>()
				.HasMany(e => e.NHANVIEN)
				.WithRequired(e => e.PHONGBAN)
				.WillCascadeOnDelete(false);
		}
	}
}
