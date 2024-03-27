namespace NailCreativeAcademy.Infrastructure.Data.SeedDataBase
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;
    public class CourseTypeConfig : IEntityTypeConfiguration<CourseType>
    {
        public void Configure(EntityTypeBuilder<CourseType> builder)
        {
            var data = new SeedDb();

            builder.HasData(new CourseType[] { data.FirstType, data.SecondType});
        }
    }
}
