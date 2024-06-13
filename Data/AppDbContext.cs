using Microsoft.EntityFrameworkCore;
using TrackItAllApi.Models;

namespace TrackItAllApi.Data {
	public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options) {
		public DbSet<Entry> Entries { get; set; }
		public DbSet<Group> Groups { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<Output> Outputs { get; set; }
		public DbSet<Batch> Batches { get; set; }
		public DbSet<ProductEntry> ProductEntries { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Entry>()
					.HasOne(e => e.Supplier)
					.WithMany()
					.HasForeignKey(e => e.SupplierId)
					.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<Product>()
					.HasOne(p => p.Group)
					.WithMany()
					.HasForeignKey(p => p.GroupId)
					.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<Output>()
					.HasOne(o => o.Product)
					.WithMany()
					.HasForeignKey(o => o.ProductId)
					.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<Batch>()
					.HasOne(b => b.Product)
					.WithMany()
					.HasForeignKey(b => b.ProductId)
					.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<Batch>()
					.HasOne(b => b.Entry)
					.WithMany()
					.HasForeignKey(b => b.EntryId)
					.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<ProductEntry>()
					.HasOne(pe => pe.Entry)
					.WithMany()
					.HasForeignKey(pe => pe.EntryId)
					.OnDelete(DeleteBehavior.NoAction);

			modelBuilder.Entity<ProductEntry>()
					.HasOne(pe => pe.Product)
					.WithMany()
					.HasForeignKey(pe => pe.ProductId)
					.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
