namespace Figma.Core.Models
{
    public class ApplicationForm
    {
        public int Id { get; set; }
        public byte[] Cover { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; } = default!;
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; } = default!;
        public virtual FigmaProgram FigmaProgram { get; set; } = default!;
        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
