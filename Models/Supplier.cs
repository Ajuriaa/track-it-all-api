namespace TrackItAllApi.Models {
	public class Supplier {
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string Phone { get; set; }
		public required string Email { get; set; }
		public required string Address { get; set; }
		public required string Rtn { get; set; }
		public DateTime? DeletedAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public string? CreatedBy { get; set; }
		public DateTime UpdatedAt { get; set; }
		public string? UpdatedBy { get; set; }
	}
}
