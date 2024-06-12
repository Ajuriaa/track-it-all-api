using HotChocolate;
using HotChocolate.Data;
using TrackItAllApi.Data;
using TrackItAllApi.Models;
using System.Linq;

namespace TrackItAllApi.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Entry> GetEntries([ScopedService] AppDbContext context)
        {
            return context.Entries;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Group> GetGroups([ScopedService] AppDbContext context)
        {
            return context.Groups;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Product> GetProducts([ScopedService] AppDbContext context)
        {
            return context.Products;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Supplier> GetSuppliers([ScopedService] AppDbContext context)
        {
            return context.Suppliers;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Output> GetOutputs([ScopedService] AppDbContext context)
        {
            return context.Outputs;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Batch> GetBatches([ScopedService] AppDbContext context)
        {
            return context.Batches;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ProductEntry> GetProductEntries([ScopedService] AppDbContext context)
        {
            return context.ProductEntries;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<User> GetUsers([ScopedService] AppDbContext context)
        {
            return context.Users;
        }
    }
}
