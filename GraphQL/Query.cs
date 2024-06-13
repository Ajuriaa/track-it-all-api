using TrackItAllApi.Data;
using TrackItAllApi.Models;
using HotChocolate.Data;

namespace TrackItAllApi.GraphQL {
	public class Query {
		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<Entry> GetEntries([Service] AppDbContext context) {
			return context.Entries;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<Group> GetGroups([Service] AppDbContext context) {
			return context.Groups;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<Product> GetProducts([Service] AppDbContext context) {
			return context.Products;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<Supplier> GetSuppliers([Service] AppDbContext context) {
			return context.Suppliers;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<Output> GetOutputs([Service] AppDbContext context) {
			return context.Outputs;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<Batch> GetBatches([Service] AppDbContext context) {
			return context.Batches;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<ProductEntry> GetProductEntries([Service] AppDbContext context) {
			return context.ProductEntries;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		public IQueryable<User> GetUsers([Service] AppDbContext context) {
			return context.Users;
		}
	}
}
