using System.ComponentModel.DataAnnotations.Schema;

namespace TrackItAllApi.Models {
	public class Product {
		public int Id { get; set; }
		public required string Name { get; set; }
		public int GroupId { get; set; }
		public required string Unit { get; set; }
		public required string ImageUrl { get; set; }
		public DateTime? DeletedAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public string? CreatedBy { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string? UpdatedBy { get; set; }

		[ForeignKey("GroupId")]
		public required Group Group { get; set; }
	}
}
