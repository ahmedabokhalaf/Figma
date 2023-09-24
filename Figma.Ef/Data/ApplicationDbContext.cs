namespace Figma.Ef.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) { }
        public DbSet<FigmaProgram> FigmaPrograms { get; set; } = default!;
        public DbSet<ApplicationForm> ApplicationForms { get; set; } = default!;
        public DbSet<Stage> Stages { get; set; } = default!;
        public DbSet<Profile> Profiles { get; set; } = default!;
        public DbSet<PersonalInfo> PersonalInfos { get; set; } = default!;
        public DbSet<WorkExperience> WorkExperiences { get; set; } = default!;
        public DbSet<Education> Educations { get; set; } = default!;
        public DbSet<Question> Questions { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new FigmaProgramConfig().Configure(modelBuilder.Entity<FigmaProgram>());
            new ApplicationFormConfig().Configure(modelBuilder.Entity<ApplicationForm>());
            new StageConfig().Configure(modelBuilder.Entity<Stage>());
            new ProfileConfig().Configure(modelBuilder.Entity<Profile>());
            new PersonalInfoConfig().Configure(modelBuilder.Entity<PersonalInfo>());
            new WorkExperienceConfig().Configure(modelBuilder.Entity<WorkExperience>());
            new EducationConfig().Configure(modelBuilder.Entity<Education>());
            modelBuilder.MapRelations();
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
