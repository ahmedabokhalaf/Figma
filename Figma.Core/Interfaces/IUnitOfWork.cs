namespace Figma.Core.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IBaseRepo<ApplicationForm> Applications { get; }
        IBaseRepo<Stage> Stages { get; }
        IBaseRepo<FigmaProgram> Programs { get; }
        IBaseRepo<Question> Questions { get; }
        IBaseRepo<WorkExperience> WorkExperiences { get; }
        IBaseRepo<Education> Educations { get; }
        IBaseRepo<PersonalInfo> PersonalInfo { get; }
        IBaseRepo<Profile> Profile { get; }
        int Save();
    }
}
