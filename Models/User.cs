namespace TrackItAllApi.Models {
	public class User {
		public int Id { get; set; }
		public required string FirstName { get; set; }
		public required string LastName { get; set; }
		public required string Username { get; set; }
		public DateTime? DeletedAt { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
