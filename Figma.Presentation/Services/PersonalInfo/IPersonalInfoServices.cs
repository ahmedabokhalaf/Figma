namespace Figma.Presentation.Services
{
    public interface IPersonalInfoServices
    {
        void Create(PersonalInfoDto dto);
        void Update(int id, PersonalInfoDto dto);
        void Delete(int id);
        PersonalInfo GetById(int id);

    }
}
