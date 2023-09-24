namespace Figma.Presentation.Services
{
    public interface IEducationServices
    {
        void Create(EducationDto dto);
        void Update(int id, EducationDto dto);
        void Delete(int id);
        Education GetById(int id);

    }
}
