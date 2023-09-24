namespace Figma.Presentation.Services
{
    public interface IApplicationFormServices
    {
        Task Create([FromForm] ApplicationFormDto applicationFormDto);
        Task Update(int id, [FromForm] ApplicationFormDto applicationFormDto);
        ApplicationForm GetById(int id);
    }
}
