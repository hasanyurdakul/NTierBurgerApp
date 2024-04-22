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
    public class OrderSeedData : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(new Order { OrderId = 1, CustomerId = 43, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 2, CustomerId = 46, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 3, CustomerId = 18, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 4, CustomerId = 11, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 5, CustomerId = 20, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 6, CustomerId = 19, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 7, CustomerId = 24, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 8, CustomerId = 30, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 9, CustomerId = 12, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 10, CustomerId = 29, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 11, CustomerId = 21, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 12, CustomerId = 42, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 13, CustomerId = 11, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 14, CustomerId = 13, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 15, CustomerId = 34, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 16, CustomerId = 39, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 17, CustomerId = 23, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 18, CustomerId = 33, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 19, CustomerId = 14, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 20, CustomerId = 7, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 21, CustomerId = 36, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 22, CustomerId = 13, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 23, CustomerId = 43, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 24, CustomerId = 39, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 25, CustomerId = 6, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 26, CustomerId = 29, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 27, CustomerId = 39, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 28, CustomerId = 37, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 29, CustomerId = 19, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 30, CustomerId = 18, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 31, CustomerId = 24, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 32, CustomerId = 10, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 33, CustomerId = 50, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 34, CustomerId = 27, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 35, CustomerId = 34, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 36, CustomerId = 41, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 37, CustomerId = 14, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 38, CustomerId = 39, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 39, CustomerId = 26, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 40, CustomerId = 10, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 41, CustomerId = 46, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 42, CustomerId = 39, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 43, CustomerId = 20, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 44, CustomerId = 5, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 45, CustomerId = 35, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 46, CustomerId = 37, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 47, CustomerId = 2, OrderDate = DateTime.Parse("2024-12-01"), Status = "Completed" },
new Order { OrderId = 48, CustomerId = 24, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 49, CustomerId = 24, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" },
new Order { OrderId = 50, CustomerId = 14, OrderDate = DateTime.Parse("2024-12-01"), Status = "Preparing" }

                );

        }
        

            
        }

        
}
