using HotChocolate.Authorization;
using TrackItAllApi.Data;
using TrackItAllApi.Models;

namespace TrackItAllApi.GraphQL {
	public class Mutation {
		[Authorize]
		public async Task<Entry> AddEntryAsync(Entry entry, [Service] AppDbContext context) {
			context.Entries.Add(entry);
			await context.SaveChangesAsync();
			return entry;
		}

		[Authorize]
		public async Task<Group> AddGroupAsync(Group group, [Service] AppDbContext context) {
			context.Groups.Add(group);
			await context.SaveChangesAsync();
			return group;
		}

		[Authorize]
		public async Task<Product> AddProductAsync(Product product, [Service] AppDbContext context) {
			context.Products.Add(product);
			await context.SaveChangesAsync();
			return product;
		}

		[Authorize]
		public async Task<Supplier> AddSupplierAsync(Supplier supplier, [Service] AppDbContext context) {
			context.Suppliers.Add(supplier);
			await context.SaveChangesAsync();
			return supplier;
		}

		[Authorize]
		public async Task<Output> AddOutputAsync(Output output, [Service] AppDbContext context) {
			context.Outputs.Add(output);
			await context.SaveChangesAsync();
			return output;
		}

		[Authorize]
		public async Task<Batch> AddBatchAsync(Batch batch, [Service] AppDbContext context) {
			context.Batches.Add(batch);
			await context.SaveChangesAsync();
			return batch;
		}

		[Authorize]
		public async Task<ProductEntry> AddProductEntryAsync(ProductEntry productEntry, [Service] AppDbContext context) {
			context.ProductEntries.Add(productEntry);
			await context.SaveChangesAsync();
			return productEntry;
		}

		[Authorize]
		public async Task<User> AddUserAsync(User user, [Service] AppDbContext context) {
			context.Users.Add(user);
			await context.SaveChangesAsync();
			return user;
		}
	}
}
