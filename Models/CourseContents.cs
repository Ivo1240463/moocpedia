namespace MOOCPediaApp.Models
{
	public class CourseContents
	{
		public string Name { get; set; } = string.Empty;

		public List<CourseContents> SubContents { get; set; } = new();
	}
}
