namespace Figma.Core.Models
{
    public class Stage
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool ShowForCandidate { get; set; }
        public int ProgramId { get; set; }
        public virtual FigmaProgram Program { get; set; } = default!;
    }
}
