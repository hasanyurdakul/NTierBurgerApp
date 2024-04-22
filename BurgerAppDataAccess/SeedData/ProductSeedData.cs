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
    public class ProductSeedData : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { ProductId = 1, Name = "Double Big King", Description = "Double Big King Menu. Comes with french fries and coke!", UnitPrice = 123, Stock = 999 },
                new Product { ProductId = 2, Name = "Texas Smokehouse", Description = "Texas Smokehouse Menu. Comes with french fries and coke!", UnitPrice = 123, Stock = 999 },
                new Product { ProductId = 3, Name = "Whopper", Description = "Whopper Menu. Comes with french fries and coke!", UnitPrice = 123, Stock = 999 },
                new Product { ProductId = 4, Name = "Triple Whopper", Description = "Triple Whopper Menu. Comes with french fries and coke!", UnitPrice = 123, Stock = 999 },
                new Product { ProductId = 5, Name = "King Beef", Description = "King Beef Menu. Comes with french fries and coke!", UnitPrice = 123, Stock = 999 },
                new Product { ProductId = 6, Name = "Nuggets", Description = "Nuggets Menu. Comes with french fries and coke!", UnitPrice = 123, Stock = 999 },
                new Product { ProductId = 7, Name = "Chicken Tenders", Description = "Chicken Tenders Menu. Comes with french fries and coke!", UnitPrice = 123, Stock = 999 }
                );




        }
    }
}
