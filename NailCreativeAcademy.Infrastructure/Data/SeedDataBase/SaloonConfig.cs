using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NailCreativeAcademy.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailCreativeAcademy.Infrastructure.Data.SeedDataBase
{
    public class SaloonConfig : IEntityTypeConfiguration<Saloon>
    {
        public void Configure(EntityTypeBuilder<Saloon> builder)
        {
            var data = new SeedDb();

            builder.HasData(new Saloon[] { data.Sallon1, data.Sallon2});
        }
    }
}
