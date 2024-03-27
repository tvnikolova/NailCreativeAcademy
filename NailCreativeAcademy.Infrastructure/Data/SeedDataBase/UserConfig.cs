namespace NailCreativeAcademy.Infrastructure.Data.SeedDataBase
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class UserConfig : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var data = new SeedDb();

            builder.HasData(new IdentityUser[] {data.AdminUser,data.StudentUser1,data.StudentUser2,data.Client1});
        }
    }
}
