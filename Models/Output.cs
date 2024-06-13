using System.ComponentModel.DataAnnotations.Schema;

namespace TrackItAllApi.Models {
	public class Output {
		public int Id { get; set; }
		public int ProductId { get; set; }
		public required string Observation { get; set; }
		public int Quantity { get; set; }
		public required string Motive { get; set; }
		public DateTime? DeletedAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public string? CreatedBy { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string? UpdatedBy { get; set; }

		[ForeignKey("ProductId")]
		public required Product Product { get; set; }
	}
}
