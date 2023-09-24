namespace Figma.Presentation.Services
{
    public interface IStageServices
    {
        void Create(StageDto dto);
        void Update(int id, StageDto dto);
        void Delete(int id);
        Stage GetById(int id);

    }
}
