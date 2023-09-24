namespace Figma.Ef.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBaseRepo<Stage> Stages { get; private set; } = default!;

        public IBaseRepo<ApplicationForm> Applications {get; private set;}

        public IBaseRepo<FigmaProgram> Programs {get; private set;}

        public IBaseRepo<Question> Questions {get; private set;}

        public IBaseRepo<WorkExperience> WorkExperiences {get; private set;}

        public IBaseRepo<Education> Educations {get; private set;}

        public IBaseRepo<PersonalInfo> PersonalInfo {get; private set;}

        public IBaseRepo<Profile> Profile {get; private set;}

        private readonly ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext _context)
        {
            context = _context;
            Applications = new BaseRepo<ApplicationForm>(context);
            Stages = new BaseRepo<Stage>(context);
            Programs = new BaseRepo<FigmaProgram>(context);
            Questions = new BaseRepo<Question>(context);
            WorkExperiences = new BaseRepo<WorkExperience>(context);
            Educations = new BaseRepo<Education>(context);
            PersonalInfo = new BaseRepo<PersonalInfo>(context);
            Profile = new BaseRepo<Profile>(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
