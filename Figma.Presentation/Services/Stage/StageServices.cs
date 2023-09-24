namespace Figma.Presentation.Services
{
    public class StageServices : IStageServices
    {
        private readonly IUnitOfWork unitOfWork;

        public StageServices(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Create(StageDto dto)
        {
            Stage stage = new()
            {
                Name = dto.Name,
                Type = dto.Type,
                ShowForCandidate = dto.ShowForCandidate
            };
            unitOfWork.Stages.Create(stage);
            unitOfWork.Save();
        }

        public void Delete(int id)
        {
            var stage = unitOfWork.Stages.Get(id);
            if(stage != null)
            {
                unitOfWork.Stages.Delete(stage);
                unitOfWork.Save();
            }
        }

        public Stage GetById(int id)
        {
            return unitOfWork.Stages.Get(id);
        }

        public void Update(int id, StageDto dto)
        {
            var stage = unitOfWork.Stages.Get(id);
            if (stage != null)
            {
                stage.Name = dto.Name;
                stage.Type = dto.Type;
                stage.ShowForCandidate = dto.ShowForCandidate;
                unitOfWork.Stages.Update(stage);
                unitOfWork.Save();
            }
        }
    }
}
