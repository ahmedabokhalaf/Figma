namespace Figma.Presentation.DTOs
{
    public class PersonalInfoDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public long Phone { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public string CurrentResidence { get; set; } = string.Empty;
        public long IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; } = default!;
        public string Gender { get; set; } = string.Empty;
        public int ApplicationFormId { get; set; }
    }
}
