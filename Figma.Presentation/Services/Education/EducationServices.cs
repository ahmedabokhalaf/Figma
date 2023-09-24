namespace Figma.Presentation.Services
{
    public class EducationServices : IEducationServices
    {
        private readonly IUnitOfWork unitOfWork;

        public EducationServices(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Create(EducationDto dto)
        {
            Education edu = new()
            {
                School = dto.School,
                Degree = dto.Degree,
                CourseName = dto.CourseName,
                CurrentStudy = dto.CurrentStudy,
                Location = dto.Location,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                ProfileId = dto.ProfileId
            };
        }

        public void Delete(int id)
        {
            var edu = unitOfWork.Educations.Get(id);
            if(edu != null)
            {
                unitOfWork.Educations.Delete(edu);
                unitOfWork.Save();
            }
        }

        public Education GetById(int id)
        {
            return unitOfWork.Educations.Get(id);
        }

        public void Update(int id, EducationDto dto)
        {
            var edu = unitOfWork.Educations.Get(id);
            if (edu != null)
            {
                edu.School = dto.School;
                edu.Degree = dto.Degree;
                edu.CourseName = dto.CourseName;
                edu.CurrentStudy = dto.CurrentStudy;
                edu.Location = dto.Location;
                edu.StartDate = dto.StartDate;
                edu.EndDate = dto.EndDate;
                edu.ProfileId = dto.ProfileId;
                unitOfWork.Educations.Update(edu);
                unitOfWork.Save();
            }
        }
    }
}
