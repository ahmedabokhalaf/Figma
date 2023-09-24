namespace Figma.Core.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public virtual Education Education { get; set; } = default!;
        public virtual WorkExperience WorkExperience { get; set; } = default!;
        public byte[] Resume { get; set; } 
        public virtual ApplicationForm ApplicationForm { get; set; } = default!;
        public virtual ICollection<Education> Educations { get; set; } = new List<Education>();
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();

    }
}
