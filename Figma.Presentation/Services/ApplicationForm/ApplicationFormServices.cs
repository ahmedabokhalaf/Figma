namespace Figma.Presentation.Services
{
    public class ApplicationFormServices : IApplicationFormServices
    {
        private readonly IUnitOfWork unitOfWork;
        private List<string> allowedExtenstions = new List<string> { ".jpg", ".png" };
        private long maxAllowedCoverSize = 10485760;
        public ApplicationFormServices(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }

        public async Task Create([FromForm] ApplicationFormDto applicationFormDto)
        {
            if (allowedExtenstions.Contains(Path.GetExtension(applicationFormDto.Cover.FileName).ToLower())
                && applicationFormDto.Cover.Length > maxAllowedCoverSize)
            {
                using var dataStream = new MemoryStream();
                await applicationFormDto.Cover.CopyToAsync(dataStream);
                ApplicationForm app = new()
                {
                    Cover = dataStream.ToArray(),
                    ProfileId = applicationFormDto.ProfileId,
                    PersonalInfoId = applicationFormDto.PersonalInfoId,
                };
                unitOfWork.Applications.Create(app);
                unitOfWork.Save();
            }
            
        }

        public ApplicationForm GetById(int id)
        {
            return unitOfWork.Applications.Get(id);
        }

        public async Task Update(int id, [FromForm] ApplicationFormDto applicationFormDto)
        {
            var app = unitOfWork.Applications.Get(id);
            if (app != null)
            {
                if (allowedExtenstions.Contains(Path.GetExtension(applicationFormDto.Cover.FileName).ToLower())
                && applicationFormDto.Cover.Length > maxAllowedCoverSize)
                {
                    using var dataStream = new MemoryStream();
                    await applicationFormDto.Cover.CopyToAsync(dataStream);
                    app.Cover = dataStream.ToArray();
                    app.ProfileId = applicationFormDto.ProfileId;
                    app.PersonalInfoId = applicationFormDto.PersonalInfoId;
                }
                unitOfWork.Applications.Update(app);
                unitOfWork.Save();
            }
        }
    }
}
