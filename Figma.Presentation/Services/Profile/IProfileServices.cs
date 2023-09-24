namespace Figma.Presentation.Services
{
    public interface IProfileServices
    {
        Task Create(ProfileDto dto);
        Task Update(int id, ProfileDto dto);
        void Delete(int id);
        Profile GetById(int id);

    }
}
