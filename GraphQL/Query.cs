using HotChocolate.Authorization;
using TrackItAllApi.Data;
using TrackItAllApi.Models;

namespace TrackItAllApi.GraphQL {
	public class Query {
		[UseProjection]
		[UseFiltering]
		[UseSorting]
		[Authorize]
		public IQueryable<Entry> GetEntries([Service] AppDbContext context) {
			return context.Entries;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		[Authorize]
		public IQueryable<Group> GetGroups([Service] AppDbContext context) {
			return context.Groups;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		[Authorize]
		public IQueryable<Product> GetProducts([Service] AppDbContext context) {
			return context.Products;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		[Authorize]
		public IQueryable<Supplier> GetSuppliers([Service] AppDbContext context) {
			return context.Suppliers;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		[Authorize]
		public IQueryable<Output> GetOutputs([Service] AppDbContext context) {
			return context.Outputs;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		[Authorize]
		public IQueryable<Batch> GetBatches([Service] AppDbContext context) {
			return context.Batches;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		[Authorize]
		public IQueryable<ProductEntry> GetProductEntries([Service] AppDbContext context) {
			return context.ProductEntries;
		}

		[UseProjection]
		[UseFiltering]
		[UseSorting]
		[Authorize]
		public IQueryable<User> GetUsers([Service] AppDbContext context) {
			return context.Users;
		}
	}
}
