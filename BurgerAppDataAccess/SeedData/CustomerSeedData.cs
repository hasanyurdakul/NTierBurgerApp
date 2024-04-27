using BurgerAppDomain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BurgerAppDataAccess.SeedData
{
    public class CustomerSeedData : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
    new Customer { CustomerId = 1, FirstName = "John", LastName = "Doe", Address = "123 Main St, Anytown, USA", Email = "john.doe@example.com", PhoneNumber = "(555) 123-4567",isActive=true },
    new Customer { CustomerId = 2, FirstName = "Emily", LastName = "Smith", Address = "456 Elm St, Smalltown, USA", Email = "emily.smith@example.com", PhoneNumber = "(555) 234-5678", isActive = true },
    new Customer { CustomerId = 3, FirstName = "Michael", LastName = "Johnson", Address = "789 Oak St, Cityville, USA", Email = "michael.johnson@example.com", PhoneNumber = "(555) 345-6789", isActive = true },
    new Customer { CustomerId = 4, FirstName = "Sarah", LastName = "Williams", Address = "101 Maple Ave, Villagetown, USA", Email = "sarah.williams@example.com", PhoneNumber = "(555) 456-7890", isActive = true },
    new Customer { CustomerId = 5, FirstName = "Christopher", LastName = "Brown", Address = "202 Cedar St, Townsville, USA", Email = "christopher.brown@example.com", PhoneNumber = "(555) 567-8901", isActive = true },
    new Customer { CustomerId = 6, FirstName = "Jessica", LastName = "Davis", Address = "303 Pine St, Hamletville, USA", Email = "jessica.davis@example.com", PhoneNumber = "(555) 678-9012", isActive = true },
    new Customer { CustomerId = 7, FirstName = "Matthew", LastName = "Miller", Address = "404 Birch St, Suburbia, USA", Email = "matthew.miller@example.com", PhoneNumber = "(555) 789-0123", isActive = true },
    new Customer { CustomerId = 8, FirstName = "Ashley", LastName = "Wilson", Address = "505 Walnut St, Riverside, USA", Email = "ashley.wilson@example.com", PhoneNumber = "(555) 890-1234", isActive = true },
    new Customer { CustomerId = 9, FirstName = "Daniel", LastName = "Moore", Address = "606 Oak St, Hillside, USA", Email = "daniel.moore@example.com", PhoneNumber = "(555) 901-2345", isActive = true },
    new Customer { CustomerId = 10, FirstName = "Amanda", LastName = "Taylor", Address = "707 Maple St, Lakeside, USA", Email = "amanda.taylor@example.com", PhoneNumber = "(555) 012-3456", isActive = true },
    new Customer { CustomerId = 11, FirstName = "Robert", LastName = "Martinez", Address = "808 Pine St, Mountainview, USA", Email = "robert.martinez@example.com", PhoneNumber = "(555) 123-4567", isActive = true },
    new Customer { CustomerId = 12, FirstName = "Jennifer", LastName = "Hernandez", Address = "909 Cedar St, Beachtown, USA", Email = "jennifer.hernandez@example.com", PhoneNumber = "(555) 234-5678", isActive = true },
    new Customer { CustomerId = 13, FirstName = "James", LastName = "Lopez", Address = "111 Birch St, Countryside, USA", Email = "james.lopez@example.com", PhoneNumber = "(555) 345-6789", isActive = true },
    new Customer { CustomerId = 14, FirstName = "Mary", LastName = "Gonzalez", Address = "222 Elm St, Riverside, USA", Email = "mary.gonzalez@example.com", PhoneNumber = "(555) 456-7890", isActive = true },
    new Customer { CustomerId = 15, FirstName = "David", LastName = "Wilson", Address = "333 Oak St, Suburbia, USA", Email = "david.wilson@example.com", PhoneNumber = "(555) 567-8901", isActive = true },
    new Customer { CustomerId = 16, FirstName = "Maria", LastName = "Taylor", Address = "444 Maple St, Cityville, USA", Email = "maria.taylor@example.com", PhoneNumber = "(555) 678-9012", isActive = true },
    new Customer { CustomerId = 17, FirstName = "Charles", LastName = "Martinez", Address = "555 Pine St, Hillside, USA", Email = "charles.martinez@example.com", PhoneNumber = "(555) 789-0123", isActive = true },
    new Customer { CustomerId = 18, FirstName = "Patricia", LastName = "Hernandez", Address = "666 Cedar St, Townsville, USA", Email = "patricia.hernandez@example.com", PhoneNumber = "(555) 890-1234", isActive = true },
    new Customer { CustomerId = 19, FirstName = "Richard", LastName = "Lopez", Address = "777 Birch St, Lakeside, USA", Email = "richard.lopez@example.com", PhoneNumber = "(555) 901-2345", isActive = true },
    new Customer { CustomerId = 20, FirstName = "Linda", LastName = "Gonzalez", Address = "888 Elm St, Beachside, USA", Email = "linda.gonzalez@example.com", PhoneNumber = "(555) 012-3456", isActive = true },
    new Customer { CustomerId = 21, FirstName = "Thomas", LastName = "Martinez", Address = "999 Pine St, Citytown, USA", Email = "thomas.martinez@example.com", PhoneNumber = "(555) 123-4567", isActive = true },
    new Customer { CustomerId = 22, FirstName = "Karen", LastName = "Hernandez", Address = "101 Oak St, Countryside, USA", Email = "karen.hernandez@example.com", PhoneNumber = "(555) 234-5678", isActive = true },
    new Customer { CustomerId = 23, FirstName = "Steven", LastName = "Lopez", Address = "202 Cedar St, Riverside, USA", Email = "steven.lopez@example.com", PhoneNumber = "(555) 345-6789", isActive = true },
    new Customer { CustomerId = 24, FirstName = "Barbara", LastName = "Gonzalez", Address = "303 Elm St, Suburbia, USA", Email = "barbara.gonzalez@example.com", PhoneNumber = "(555) 456-7890", isActive = true },
    new Customer { CustomerId = 25, FirstName = "Joseph", LastName = "Taylor", Address = "404 Maple St, Hillside, USA", Email = "joseph.taylor@example.com", PhoneNumber = "(555) 567-8901", isActive = true },
    new Customer { CustomerId = 26, FirstName = "Donna", LastName = "Martinez", Address = "505 Pine St, Lakeside, USA", Email = "donna.martinez@example.com", PhoneNumber = "(555) 678-9012", isActive = true },
    new Customer { CustomerId = 27, FirstName = "Ronald", LastName = "Hernandez", Address = "606 Oak St, Beachside, USA", Email = "ronald.hernandez@example.com", PhoneNumber = "(555) 789-0123", isActive = true },
    new Customer { CustomerId = 28, FirstName = "Laura", LastName = "Lopez", Address = "707 Cedar St, Smalltown, USA", Email = "laura.lopez@example.com", PhoneNumber = "(555) 890-1234", isActive = true },
    new Customer { CustomerId = 29, FirstName = "Kenneth", LastName = "Gonzalez", Address = "808 Elm St, Mountainview, USA", Email = "kenneth.gonzalez@example.com", PhoneNumber = "(555) 901-2345", isActive = true },
    new Customer { CustomerId = 30, FirstName = "Margaret", LastName = "Wilson", Address = "909 Oak St, Beachtown, USA", Email = "margaret.wilson@example.com", PhoneNumber = "(555) 012-3456", isActive = true },
    new Customer { CustomerId = 31, FirstName = "Karen", LastName = "Martinez", Address = "101 Maple Ave, Cityville, USA", Email = "karen.martinez@example.com", PhoneNumber = "(555) 123-4567", isActive = true },
    new Customer { CustomerId = 32, FirstName = "Anthony", LastName = "Hernandez", Address = "202 Cedar St, Townsville, USA", Email = "anthony.hernandez@example.com", PhoneNumber = "(555) 234-5678", isActive = true },
    new Customer { CustomerId = 33, FirstName = "Sharon", LastName = "Lopez", Address = "303 Elm St, Hillside, USA", Email = "sharon.lopez@example.com", PhoneNumber = "(555) 345-6789", isActive = true },
    new Customer { CustomerId = 34, FirstName = "Gary", LastName = "Gonzalez", Address = "404 Pine St, Countryside, USA", Email = "gary.gonzalez@example.com", PhoneNumber = "(555) 456-7890", isActive = true },
    new Customer { CustomerId = 35, FirstName = "Deborah", LastName = "Taylor", Address = "505 Cedar St, Riverside, USA", Email = "deborah.taylor@example.com", PhoneNumber = "(555) 567-8901", isActive = true },
    new Customer { CustomerId = 36, FirstName = "Edward", LastName = "Martinez", Address = "606 Oak St, Suburbia, USA", Email = "edward.martinez@example.com", PhoneNumber = "(555) 678-9012", isActive = true },
    new Customer { CustomerId = 37, FirstName = "Kimberly", LastName = "Hernandez", Address = "707 Elm St, Lakeside, USA", Email = "kimberly.hernandez@example.com", PhoneNumber = "(555) 789-0123", isActive = true },
    new Customer { CustomerId = 38, FirstName = "Steven", LastName = "Lopez", Address = "808 Cedar St, Beachside, USA", Email = "steven.lopez@example.com", PhoneNumber = "(555) 890-1234", isActive = true },
    new Customer { CustomerId = 39, FirstName = "Susan", LastName = "Gonzalez", Address = "909 Elm St, Mountainview, USA", Email = "susan.gonzalez@example.com", PhoneNumber = "(555) 901-2345", isActive = true },
    new Customer { CustomerId = 40, FirstName = "Brian", LastName = "Wilson", Address = "101 Pine St, Beachtown, USA", Email = "brian.wilson@example.com", PhoneNumber = "(555) 012-3456", isActive = true },
    new Customer { CustomerId = 41, FirstName = "Elizabeth", LastName = "Martinez", Address = "202 Maple Ave, Cityville, USA", Email = "elizabeth.martinez@example.com", PhoneNumber = "(555) 123-4567", isActive = true },
    new Customer { CustomerId = 42, FirstName = "Charles", LastName = "Hernandez", Address = "303 Oak St, Townsville, USA", Email = "charles.hernandez@example.com", PhoneNumber = "(555) 234-5678", isActive = true },
    new Customer { CustomerId = 43, FirstName = "Donna", LastName = "Lopez", Address = "404 Elm St, Hillside, USA", Email = "donna.lopez@example.com", PhoneNumber = "(555) 345-6789", isActive = true },
    new Customer { CustomerId = 44, FirstName = "David", LastName = "Gonzalez", Address = "505 Cedar St, Countryside, USA", Email = "david.gonzalez@example.com", PhoneNumber = "(555) 456-7890", isActive = true },
    new Customer { CustomerId = 45, FirstName = "Jennifer", LastName = "Taylor", Address = "606 Maple St, Riverside, USA", Email = "jennifer.taylor@example.com", PhoneNumber = "(555) 567-8901", isActive = true },
    new Customer { CustomerId = 46, FirstName = "Michael", LastName = "Martinez", Address = "707 Elm St, Suburbia, USA", Email = "michael.martinez@example.com", PhoneNumber = "(555) 678-9012", isActive = true },
    new Customer { CustomerId = 47, FirstName = "Barbara", LastName = "Hernandez", Address = "808 Pine St, Lakeside, USA", Email = "barbara.hernandez@example.com", PhoneNumber = "(555) 789-0123", isActive = true },
    new Customer { CustomerId = 48, FirstName = "John", LastName = "Lopez", Address = "909 Oak St, Beachside, USA", Email = "john.lopez@example.com", PhoneNumber = "(555) 890-1234", isActive = true },
    new Customer { CustomerId = 49, FirstName = "Jessica", LastName = "Gonzalez", Address = "101 Cedar St, Mountainview, USA", Email = "jessica.gonzalez@example.com", PhoneNumber = "(555) 901-2345", isActive = true },
    new Customer { CustomerId = 50, FirstName = "Jason", LastName = "Taylor", Address = "202 Pine St, Smalltown, USA", Email = "jason.taylor@example.com", PhoneNumber = "(555) 012-3456", isActive = true });
        }
    }
}
