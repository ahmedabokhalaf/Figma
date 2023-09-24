namespace Figma.Presentation.Services
{
    public interface IWorkExperienceServices
    {
        void Create(WorkExperienceDto dto);
        void Update(int id, WorkExperienceDto dto);
        void Delete(int id);
        WorkExperience GetById(int id);

    }
}
