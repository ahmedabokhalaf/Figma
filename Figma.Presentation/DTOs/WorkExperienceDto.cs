namespace Figma.Presentation.DTOs
{
    public class WorkExperienceDto
    {
        public int Id { get; set; }
        public string Company { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = default!;
        public DateTime EndDate { get; set; } = default!;
        public bool CurrentlyWork { get; set; }
        public int ProfileId { get; set; }
    }
}
