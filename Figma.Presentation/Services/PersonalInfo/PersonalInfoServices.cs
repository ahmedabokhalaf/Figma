namespace Figma.Presentation.Services
{
    public class PersonalInfoServices : IPersonalInfoServices
    {
        private readonly IUnitOfWork unitOfWork;

        public PersonalInfoServices(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Create(PersonalInfoDto dto)
        {
            PersonalInfo info = new()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Phone = dto.Phone,
                Nationality = dto.Nationality,
                CurrentResidence = dto.CurrentResidence,
                IdNumber = dto.IdNumber,
                DateOfBirth = dto.DateOfBirth,
                Gender = dto.Gender,
                ApplicationFormId = dto.ApplicationFormId,
            };
            unitOfWork.PersonalInfo.Create(info);
            unitOfWork.Save();
        }

        public void Delete(int id)
        {
            var info = unitOfWork.PersonalInfo.Get(id);
            if (info != null)
            {
                unitOfWork.PersonalInfo.Delete(info);
                unitOfWork.Save();
            }
        }

        public PersonalInfo GetById(int id)
        {
            return unitOfWork.PersonalInfo.Get(id);
        }

        public void Update(int id, PersonalInfoDto dto)
        {
            var info = unitOfWork.PersonalInfo.Get(id);
            if (info != null)
            {
                info.FirstName = dto.FirstName;
                info.LastName = dto.LastName;
                info.Email = dto.Email;
                info.Phone = dto.Phone;
                info.Nationality = dto.Nationality;
                info.CurrentResidence = dto.CurrentResidence;
                info.IdNumber = dto.IdNumber;
                info.DateOfBirth = dto.DateOfBirth;
                info.Gender = dto.Gender;
                info.ApplicationFormId = dto.ApplicationFormId;
                unitOfWork.PersonalInfo.Update(info);
                unitOfWork.Save();
            }
        }
    }
}
