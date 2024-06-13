using System.ComponentModel.DataAnnotations.Schema;

namespace TrackItAllApi.Models {
	public class ProductEntry {
		public int Id { get; set; }
		public int EntryId { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public DateTime? DeletedAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public string? CreatedBy { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string? UpdatedBy { get; set; }

		[ForeignKey("EntryId")]
		public required Entry Entry { get; set; }

		[ForeignKey("ProductId")]
		public required Product Product { get; set; }
	}
}
