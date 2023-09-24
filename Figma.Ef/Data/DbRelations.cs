namespace Figma.Ef.Data
{
    public static class DbRelations
    {
        public static void MapRelations(this ModelBuilder builder)
        {
            builder.Entity<ApplicationForm>()
                .HasOne(i => i.PersonalInfo).WithOne(e => e.ApplicationForm)
                .HasForeignKey<PersonalInfo>(e => e.ApplicationFormId).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ApplicationForm>()
                .HasOne(e=>e.Profile).WithOne(e=>e.ApplicationForm)
                .HasForeignKey<ApplicationForm>(e=>e.ProfileId).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ApplicationForm>()
                .HasOne(e=>e.FigmaProgram).WithOne(e=>e.Application)
                .HasForeignKey<FigmaProgram>(e=>e.ApplicationId).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ApplicationForm>()
                .HasMany(a => a.Questions).WithMany(q => q.Applications).UsingEntity<Dictionary<string, object>>(
                    "ApplicationsQuestions",
                    a => a.HasOne<Question>().WithMany().HasForeignKey("QuestionId"),
                    b => b.HasOne<ApplicationForm>().WithMany().HasForeignKey("ApplicationId")
                );

            builder.Entity<Education>()
                .HasOne(e => e.Profile).WithMany(e => e.Educations)
                .HasForeignKey(e => e.ProfileId).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<WorkExperience>()
                .HasOne(e => e.Profile).WithMany(e => e.WorkExperiences)
                .HasForeignKey(e => e.ProfileId).OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Stage>()
                .HasOne(e => e.Program).WithOne(e => e.Stage)
                .HasForeignKey<Stage>(e => e.ProgramId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
