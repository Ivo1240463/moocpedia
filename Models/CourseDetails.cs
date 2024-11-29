namespace MOOCPediaApp.Models
{
	public class CourseDetails
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string ImageUrl { get; set; } = string.Empty;
		public int Rating;
		public int Students { get; set; }
		public int VideoTime { get; set; }
		public int QuizCount { get; set; }
		public int ArticlesCount { get; set; }
		public int DownloadableResourcesCount { get; set; }
		public List<CourseContents> CourseContents { get; set; } = new();
	}
}
