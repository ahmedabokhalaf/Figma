namespace Figma.Presentation.Services
{
    public class ProfileServices : IProfileServices
    {
        private readonly IUnitOfWork unitOfWork;
        private List<string> allowedExtenstions = new List<string> { ".pdf", ".docx" };
        private long maxAllowedCoverSize = 10485760;
        public ProfileServices(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task Create(ProfileDto dto)
        {
            if (allowedExtenstions.Contains(Path.GetExtension(dto.Resume.FileName).ToLower())
                && dto.Resume.Length <= maxAllowedCoverSize)
            {
                using var dataStream = new MemoryStream();
                await dto.Resume.CopyToAsync(dataStream);
                Profile profile = new()
                {
                    Resume = dataStream.ToArray()
                };
                unitOfWork.Profile.Create(profile);
                unitOfWork.Save();
            }

        }

        public void Delete(int id)
        {
            var profile = unitOfWork.Profile.Get(id);
            if(profile != null)
            {
                unitOfWork.Profile.Delete(profile);
                unitOfWork.Save();
            }
        }

        public Profile GetById(int id)
        {
            return unitOfWork.Profile.Get(id);
        }

        public async Task Update(int id, ProfileDto dto)
        {
            var profile = unitOfWork.Profile.Get(id);
            if (profile != null)
            {
                if (allowedExtenstions.Contains(Path.GetExtension(dto.Resume.FileName).ToLower())
                && dto.Resume.Length > maxAllowedCoverSize)
                {
                    using var dataStream = new MemoryStream();
                    await dto.Resume.CopyToAsync(dataStream);
                    profile.Resume = dataStream.ToArray();
                    unitOfWork.Profile.Create(profile);
                    unitOfWork.Save();
                }
            }
        }
    }
}
