namespace NailCreativeAcademy.Infrastructure.Data.SeedDataBase
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    public class TrainerConfig : IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            var data = new SeedDb();

            builder.HasData(new Trainer []{data.FirstTrainer, data.SecondTrainer, data.ThirdTrainer});
        }
    }
}
