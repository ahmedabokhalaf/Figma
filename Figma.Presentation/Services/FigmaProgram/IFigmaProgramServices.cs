namespace Figma.Presentation.Services
{
    public interface IFigmaProgramServices
    {
        void Create(FigmaProgramDto dto);
        void Update(int id, FigmaProgramDto dto);
        FigmaProgram GetById(int id);

    }
}
