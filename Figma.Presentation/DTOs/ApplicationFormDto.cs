namespace Figma.Presentation.DTOs
{
    public class ApplicationFormDto
    {
        public int Id { get; set; }
        public IFormFile Cover { get; set; } = default!;
        public int ProfileId { get; set; }
        public int PersonalInfoId { get; set; }
    }
}
