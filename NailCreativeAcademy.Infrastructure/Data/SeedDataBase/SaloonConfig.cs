namespace NailCreativeAcademy.Infrastructure.Data.SeedDataBase
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    public class SaloonConfig : IEntityTypeConfiguration<Saloon>
    {
        public void Configure(EntityTypeBuilder<Saloon> builder)
        {
            var data = new SeedDb();

            builder.HasData(new Saloon[] { data.Sallon1, data.Sallon2});
        }
    }
}
