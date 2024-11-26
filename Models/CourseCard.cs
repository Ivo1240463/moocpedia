namespace MOOCPediaApp.Models
{
	public class CourseCard
	{
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string? ImageUrl { get; set; }
		public int Rate { get; set; } = 0;
		public int Ratings { get; set; } = 0;
	}
}
