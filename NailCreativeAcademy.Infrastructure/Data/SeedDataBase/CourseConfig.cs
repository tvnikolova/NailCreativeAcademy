namespace NailCreativeAcademy.Infrastructure.Data.SeedDataBase
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            var data = new SeedDb();

            builder.HasData(new Course[] { data.BasicManicureCourse});
        }
    }
}
