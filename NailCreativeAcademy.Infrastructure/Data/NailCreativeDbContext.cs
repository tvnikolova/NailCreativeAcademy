namespace NailCreativeAcademy.Infrastructure.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;
    using SeedDataBase;

    public class NailCreativeDbContext : IdentityDbContext
    {

        public NailCreativeDbContext(DbContextOptions<NailCreativeDbContext> options)
            : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<CourseType> CoursesTypes { get; set; } = null!;
        public DbSet<EnrolledStudent> EnrolledStudents { get; set; } = null!;
        public DbSet<Trainer> Trainers { get; set; } = null!;
        public DbSet<Saloon> Saloons { get; set; } = null!;
        public DbSet<Feedback> Feedbacks { get; set; } = null!;
        public DbSet<FeedbackBoard> FeedbacksBoards { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<EnrolledStudent>()
                    .HasKey(sp => new { sp.CourseId, sp.StudentId });

            builder.Entity<EnrolledStudent>()
                    .HasOne(sp => sp.Course)
                    .WithMany(sp => sp.EnrolledStudents)
                    .OnDelete(DeleteBehavior.Restrict);

          
            builder.ApplyConfiguration(new CourseTypeConfig());
            builder.ApplyConfiguration(new SaloonConfig());
            builder.ApplyConfiguration(new TrainerConfig());
            builder.ApplyConfiguration(new UserConfig());

            base.OnModelCreating(builder);
        }
    }
}
