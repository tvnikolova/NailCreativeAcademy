namespace NailCreativeAcademy.Infrastructure.Data.SeedDataBase
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using NailCreativeAcademy.Infrastructure.Data.Models;

    public class UserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var data = new SeedDb();

            builder.HasData(new ApplicationUser[] {data.AdminUser,data.StudentUser1,data.StudentUser2,data.Client1});
        }
    }
}
