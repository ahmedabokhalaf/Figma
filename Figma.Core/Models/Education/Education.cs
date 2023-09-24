
namespace Figma.Core.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string School { get; set; } = string.Empty;
        public string Degree { get; set; } = string.Empty;
        public string CourseName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = default!;
        public DateTime EndDate { get; set; } = default!;
        public bool CurrentStudy { get; set; }
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; } = default!;
    }
}
