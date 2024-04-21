using BurgerAppDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BurgerAppDomain;
using Microsoft.EntityFrameworkCore;


namespace BurgerAppDataAccess.SeedData
{
    public class CustomerSeedData : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer { CustomerId = 1, FirstName = "Hasan", LastName = "Yurdakul", Address = "İstanbul", Email = "hasan@gmail.com", PhoneNumber = "5555555555" },
                new Customer { CustomerId = 2, FirstName = "John", LastName = "Doe", Address = "Ankara", Email = "john@gmail.com", PhoneNumber = "5555555555" },
                new Customer { CustomerId = 3, FirstName = "Jane", LastName = "Thompson", Address = "İzmir", Email = "jane@gmail.com", PhoneNumber = "5555555555" },
                new Customer { CustomerId = 4, FirstName = "Dana", LastName = "Ahern", Address = "Bursa", Email = "dana@gmail.com", PhoneNumber = "5555555555" }, 
                new Customer { CustomerId = 5, FirstName = "Carol", LastName = "Jackson", Address = "Antalya", Email = "carol@gmail.com", PhoneNumber = "5555555555" });
        }
    }
}
