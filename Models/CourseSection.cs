namespace MOOCPediaApp.Models
{
    public class CourseSection
    {
        public required string Title { get; set; }
        public bool IsExpanded { get; set; } = false;
        public required List<Lesson> Lessons { get; set; }
    }
}
