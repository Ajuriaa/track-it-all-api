using System.ComponentModel.DataAnnotations.Schema;

namespace TrackItAllApi.Models {
	public class Entry {
		public int Id { get; set; }
		public int SupplierId { get; set; }
		public DateTime Date { get; set; }
		public string? InvoiceUrl { get; set; }
		public DateTime? DeletedAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public string? CreatedBy { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string? UpdatedBy { get; set; }

		[ForeignKey("SupplierId")]
		public required Supplier Supplier { get; set; }
	}
}
