namespace NailCreativeAcademy.Infrastructure.Data.SeedDataBase
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserClaimsConfig : IEntityTypeConfiguration<IdentityUserClaim<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder)
        {
            var data = new SeedDb();

            builder.HasData(data.AdminUserClaim, data.StudentUser1Claim, data.StudentUser2Claim, data.Client1Claim);
        }
    }
}
