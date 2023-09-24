namespace Figma.Presentation.Services
{
    public class WorkExperienceServices : IWorkExperienceServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public WorkExperienceServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(WorkExperienceDto dto)
        {
            WorkExperience experience = new()
            {
                Company = dto.Company,
                Title = dto.Title,
                Location = dto.Location,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                CurrentlyWork = dto.CurrentlyWork,
                ProfileId = dto.ProfileId,
            };
            _unitOfWork.WorkExperiences.Create(experience);
            _unitOfWork.Save();
        }
                
        public void Delete(int id)
        {
            var experience = _unitOfWork.WorkExperiences.Get(id);
            if (experience != null)
            {
                _unitOfWork.WorkExperiences.Delete(experience);
                _unitOfWork.Save();
            }
        }

        public WorkExperience GetById(int id)
        {
            return _unitOfWork.WorkExperiences.Get(id);
        }

        public void Update(int id, WorkExperienceDto dto)
        {
            var experience = _unitOfWork.WorkExperiences.Get(id);
            if (experience != null)
            {
                experience.Company = dto.Company;
                experience.Title = dto.Title;
                experience.Location = dto.Location;
                experience.StartDate = dto.StartDate;
                experience.EndDate = dto.EndDate;
                experience.CurrentlyWork = dto.CurrentlyWork;
                experience.ProfileId = dto.ProfileId;
                _unitOfWork.WorkExperiences.Update(experience);
                _unitOfWork.Save();
            }
        }
    }
}
