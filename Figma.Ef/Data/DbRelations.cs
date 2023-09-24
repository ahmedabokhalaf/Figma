namespace Figma.Ef.Data
{
    public static class DbRelations
    {
        public static void MapRelations(this ModelBuilder builder)
        {
            builder.Entity<ApplicationForm>()
                .HasOne(e => e.PersonalInfo).WithOne(e => e.ApplicationForm)
                .HasForeignKey<PersonalInfo>(e=>e.ApplicationFormId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<ApplicationForm>()
                .HasOne(e => e.Profile).WithOne(e => e.ApplicationForm)
                .HasForeignKey<ApplicationForm>(e => e.ProfileId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<Education>()
                .HasOne(e=>e.Profile).WithMany(e => e.Educations)
                .HasForeignKey(e=>e.ProfileId).OnDelete(DeleteBehavior.Cascade);
            builder.Entity<WorkExperience>()
                .HasOne(e => e.Profile).WithMany(e => e.WorkExperiences)
                .HasForeignKey(e => e.ProfileId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
