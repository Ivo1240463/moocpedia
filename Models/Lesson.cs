public class Lesson
{
    public required string Name { get; set; }
    public required string Duration { get; set; }
    public required string Path { get; set; }

    public required string ContentType { get; set; }
    public bool IsWatched { get; set; } = false;
}
