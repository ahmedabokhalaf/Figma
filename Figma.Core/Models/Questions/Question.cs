namespace Figma.Core.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string QuestionFormula { get; set; } = string.Empty;
        public virtual ICollection<ApplicationForm> Applications { get; set; } = new List<ApplicationForm>();
    }
}
