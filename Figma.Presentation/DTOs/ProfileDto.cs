namespace Figma.Presentation.DTOs
{
    public class ProfileDto
    {
        public int Id { get; set; }
        public IFormFile Resume { get; set; } = default!;
        public int ProfileId { get; set; }
    }
}
