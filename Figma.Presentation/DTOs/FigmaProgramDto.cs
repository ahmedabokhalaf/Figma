namespace Figma.Presentation.DTOs
{
    public class FigmaProgramDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Skills { get; set; } = string.Empty;
        public string Benefits { get; set; } = string.Empty;
        public string Criteria { get; set; } = string.Empty;
        public string ProgramType { get; set; } = string.Empty;
        public DateTime ProgramStart { get; set; } = default!;
        public DateTime ApplicationOpen { get; set; } = default!;
        public DateTime ApplicationClose { get; set; } = default!;
        public string Duration { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string MinQualifications { get; set; } = string.Empty;
        public int MaxNumber { get; set; }
    }
}
