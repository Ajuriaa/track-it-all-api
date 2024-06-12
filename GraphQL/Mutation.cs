using HotChocolate;
using HotChocolate.Data;
using TrackItAllApi.Data;
using TrackItAllApi.Models;
using System.Threading.Tasks;

namespace TrackItAllApi.GraphQL {
	public class Mutation {
		[UseDbContext(typeof(AppDbContext))]
		public async Task<Entry> AddEntryAsync(Entry entry, [ScopedService] AppDbContext context) {
			context.Entries.Add(entry);
			await context.SaveChangesAsync();
			return entry;
		}

		[UseDbContext(typeof(AppDbContext))]
		public async Task<Group> AddGroupAsync(Group group, [ScopedService] AppDbContext context) {
			context.Groups.Add(group);
			await context.SaveChangesAsync();
			return group;
		}

		[UseDbContext(typeof(AppDbContext))]
		public async Task<Product> AddProductAsync(Product product, [ScopedService] AppDbContext context) {
			context.Products.Add(product);
			await context.SaveChangesAsync();
			return product;
		}

		[UseDbContext(typeof(AppDbContext))]
		public async Task<Supplier> AddSupplierAsync(Supplier supplier, [ScopedService] AppDbContext context) {
			context.Suppliers.Add(supplier);
			await context.SaveChangesAsync();
			return supplier;
		}

		[UseDbContext(typeof(AppDbContext))]
		public async Task<Output> AddOutputAsync(Output output, [ScopedService] AppDbContext context) {
			context.Outputs.Add(output);
			await context.SaveChangesAsync();
			return output;
		}

		[UseDbContext(typeof(AppDbContext))]
		public async Task<Batch> AddBatchAsync(Batch batch, [ScopedService] AppDbContext context) {
			context.Batches.Add(batch);
			await context.SaveChangesAsync();
			return batch;
		}

		[UseDbContext(typeof(AppDbContext))]
		public async Task<ProductEntry> AddProductEntryAsync(ProductEntry productEntry, [ScopedService] AppDbContext context) {
			context.ProductEntries.Add(productEntry);
			await context.SaveChangesAsync();
			return productEntry;
		}

		[UseDbContext(typeof(AppDbContext))]
		public async Task<User> AddUserAsync(User user, [ScopedService] AppDbContext context) {
			context.Users.Add(user);
			await context.SaveChangesAsync();
			return user;
		}
	}
}
