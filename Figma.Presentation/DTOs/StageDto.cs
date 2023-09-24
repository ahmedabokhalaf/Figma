namespace Figma.Presentation.DTOs
{
    public class StageDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool ShowForCandidate { get; set; }
    }
}
