namespace Figma.Presentation.Services
{
    public class FigmaProgramServices : IFigmaProgramServices
    {
        private readonly IUnitOfWork unitOfWork;

        public FigmaProgramServices(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Create(FigmaProgramDto dto)
        {
            FigmaProgram program = new()
            {
                Title = dto.Title,
                Summary = dto.Summary,
                Skills = dto.Skills,
                Description = dto.Description,
                Benefits = dto.Benefits,
                Criteria = dto.Criteria,
                ProgramType = dto.ProgramType,
                ProgramStart = dto.ProgramStart,
                ApplicationClose = dto.ApplicationClose,
                ApplicationOpen = dto.ApplicationOpen,
                Duration = dto.Duration,
                Location = dto.Location,
                MinQualifications = dto.MinQualifications,
                MaxNumber = dto.MaxNumber
            };
            unitOfWork.Programs.Create(program);
            unitOfWork.Save();
        }

        public FigmaProgram GetById(int id)
        {
            return unitOfWork.Programs.Get(id);
        }

        public void Update(int id, FigmaProgramDto dto)
        {
            var program = unitOfWork.Programs.Get(id);
            if (program != null)
            {
                program.Title = dto.Title;
                program.Summary = dto.Summary;
                program.Skills = dto.Skills;
                program.Description = dto.Description;
                program.Benefits = dto.Benefits;
                program.Criteria = dto.Criteria;
                program.ProgramType = dto.ProgramType;
                program.ProgramStart = dto.ProgramStart;
                program.ApplicationClose = dto.ApplicationClose;
                program.ApplicationOpen = dto.ApplicationOpen;
                program.Duration = dto.Duration;
                program.Location = dto.Location;
                program.MinQualifications = dto.MinQualifications;
                program.MaxNumber = dto.MaxNumber;
                unitOfWork.Programs.Update(program);
                unitOfWork.Save();
            }
            
        }
    }
}
