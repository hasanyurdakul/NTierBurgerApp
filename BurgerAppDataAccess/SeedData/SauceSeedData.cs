using BurgerAppDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerAppDataAccess.SeedData
{
    public class SauceSeedData : IEntityTypeConfiguration<Sauce>
    {
        public void Configure(EntityTypeBuilder<Sauce> builder)
        {
            builder.HasData(
                new Sauce { SauceId = 1, SauceName = "Ketchup" },
                new Sauce { SauceId = 2, SauceName = "Mayonnaise" },
                new Sauce { SauceId = 3, SauceName = "Mustard" }
                );
        }
    }
}
