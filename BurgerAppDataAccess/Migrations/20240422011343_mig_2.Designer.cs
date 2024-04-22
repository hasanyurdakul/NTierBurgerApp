﻿// <auto-generated />
using System;
using BurgerAppDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerAppDataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240422011343_mig_2")]
    partial class mig_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BurgerAppDomain.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "123 Main St, Anytown, USA",
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "(555) 123-4567"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "456 Elm St, Smalltown, USA",
                            Email = "emily.smith@example.com",
                            FirstName = "Emily",
                            LastName = "Smith",
                            PhoneNumber = "(555) 234-5678"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "789 Oak St, Cityville, USA",
                            Email = "michael.johnson@example.com",
                            FirstName = "Michael",
                            LastName = "Johnson",
                            PhoneNumber = "(555) 345-6789"
                        },
                        new
                        {
                            CustomerId = 4,
                            Address = "101 Maple Ave, Villagetown, USA",
                            Email = "sarah.williams@example.com",
                            FirstName = "Sarah",
                            LastName = "Williams",
                            PhoneNumber = "(555) 456-7890"
                        },
                        new
                        {
                            CustomerId = 5,
                            Address = "202 Cedar St, Townsville, USA",
                            Email = "christopher.brown@example.com",
                            FirstName = "Christopher",
                            LastName = "Brown",
                            PhoneNumber = "(555) 567-8901"
                        },
                        new
                        {
                            CustomerId = 6,
                            Address = "303 Pine St, Hamletville, USA",
                            Email = "jessica.davis@example.com",
                            FirstName = "Jessica",
                            LastName = "Davis",
                            PhoneNumber = "(555) 678-9012"
                        },
                        new
                        {
                            CustomerId = 7,
                            Address = "404 Birch St, Suburbia, USA",
                            Email = "matthew.miller@example.com",
                            FirstName = "Matthew",
                            LastName = "Miller",
                            PhoneNumber = "(555) 789-0123"
                        },
                        new
                        {
                            CustomerId = 8,
                            Address = "505 Walnut St, Riverside, USA",
                            Email = "ashley.wilson@example.com",
                            FirstName = "Ashley",
                            LastName = "Wilson",
                            PhoneNumber = "(555) 890-1234"
                        },
                        new
                        {
                            CustomerId = 9,
                            Address = "606 Oak St, Hillside, USA",
                            Email = "daniel.moore@example.com",
                            FirstName = "Daniel",
                            LastName = "Moore",
                            PhoneNumber = "(555) 901-2345"
                        },
                        new
                        {
                            CustomerId = 10,
                            Address = "707 Maple St, Lakeside, USA",
                            Email = "amanda.taylor@example.com",
                            FirstName = "Amanda",
                            LastName = "Taylor",
                            PhoneNumber = "(555) 012-3456"
                        },
                        new
                        {
                            CustomerId = 11,
                            Address = "808 Pine St, Mountainview, USA",
                            Email = "robert.martinez@example.com",
                            FirstName = "Robert",
                            LastName = "Martinez",
                            PhoneNumber = "(555) 123-4567"
                        },
                        new
                        {
                            CustomerId = 12,
                            Address = "909 Cedar St, Beachtown, USA",
                            Email = "jennifer.hernandez@example.com",
                            FirstName = "Jennifer",
                            LastName = "Hernandez",
                            PhoneNumber = "(555) 234-5678"
                        },
                        new
                        {
                            CustomerId = 13,
                            Address = "111 Birch St, Countryside, USA",
                            Email = "james.lopez@example.com",
                            FirstName = "James",
                            LastName = "Lopez",
                            PhoneNumber = "(555) 345-6789"
                        },
                        new
                        {
                            CustomerId = 14,
                            Address = "222 Elm St, Riverside, USA",
                            Email = "mary.gonzalez@example.com",
                            FirstName = "Mary",
                            LastName = "Gonzalez",
                            PhoneNumber = "(555) 456-7890"
                        },
                        new
                        {
                            CustomerId = 15,
                            Address = "333 Oak St, Suburbia, USA",
                            Email = "david.wilson@example.com",
                            FirstName = "David",
                            LastName = "Wilson",
                            PhoneNumber = "(555) 567-8901"
                        },
                        new
                        {
                            CustomerId = 16,
                            Address = "444 Maple St, Cityville, USA",
                            Email = "maria.taylor@example.com",
                            FirstName = "Maria",
                            LastName = "Taylor",
                            PhoneNumber = "(555) 678-9012"
                        },
                        new
                        {
                            CustomerId = 17,
                            Address = "555 Pine St, Hillside, USA",
                            Email = "charles.martinez@example.com",
                            FirstName = "Charles",
                            LastName = "Martinez",
                            PhoneNumber = "(555) 789-0123"
                        },
                        new
                        {
                            CustomerId = 18,
                            Address = "666 Cedar St, Townsville, USA",
                            Email = "patricia.hernandez@example.com",
                            FirstName = "Patricia",
                            LastName = "Hernandez",
                            PhoneNumber = "(555) 890-1234"
                        },
                        new
                        {
                            CustomerId = 19,
                            Address = "777 Birch St, Lakeside, USA",
                            Email = "richard.lopez@example.com",
                            FirstName = "Richard",
                            LastName = "Lopez",
                            PhoneNumber = "(555) 901-2345"
                        },
                        new
                        {
                            CustomerId = 20,
                            Address = "888 Elm St, Beachside, USA",
                            Email = "linda.gonzalez@example.com",
                            FirstName = "Linda",
                            LastName = "Gonzalez",
                            PhoneNumber = "(555) 012-3456"
                        },
                        new
                        {
                            CustomerId = 21,
                            Address = "999 Pine St, Citytown, USA",
                            Email = "thomas.martinez@example.com",
                            FirstName = "Thomas",
                            LastName = "Martinez",
                            PhoneNumber = "(555) 123-4567"
                        },
                        new
                        {
                            CustomerId = 22,
                            Address = "101 Oak St, Countryside, USA",
                            Email = "karen.hernandez@example.com",
                            FirstName = "Karen",
                            LastName = "Hernandez",
                            PhoneNumber = "(555) 234-5678"
                        },
                        new
                        {
                            CustomerId = 23,
                            Address = "202 Cedar St, Riverside, USA",
                            Email = "steven.lopez@example.com",
                            FirstName = "Steven",
                            LastName = "Lopez",
                            PhoneNumber = "(555) 345-6789"
                        },
                        new
                        {
                            CustomerId = 24,
                            Address = "303 Elm St, Suburbia, USA",
                            Email = "barbara.gonzalez@example.com",
                            FirstName = "Barbara",
                            LastName = "Gonzalez",
                            PhoneNumber = "(555) 456-7890"
                        },
                        new
                        {
                            CustomerId = 25,
                            Address = "404 Maple St, Hillside, USA",
                            Email = "joseph.taylor@example.com",
                            FirstName = "Joseph",
                            LastName = "Taylor",
                            PhoneNumber = "(555) 567-8901"
                        },
                        new
                        {
                            CustomerId = 26,
                            Address = "505 Pine St, Lakeside, USA",
                            Email = "donna.martinez@example.com",
                            FirstName = "Donna",
                            LastName = "Martinez",
                            PhoneNumber = "(555) 678-9012"
                        },
                        new
                        {
                            CustomerId = 27,
                            Address = "606 Oak St, Beachside, USA",
                            Email = "ronald.hernandez@example.com",
                            FirstName = "Ronald",
                            LastName = "Hernandez",
                            PhoneNumber = "(555) 789-0123"
                        },
                        new
                        {
                            CustomerId = 28,
                            Address = "707 Cedar St, Smalltown, USA",
                            Email = "laura.lopez@example.com",
                            FirstName = "Laura",
                            LastName = "Lopez",
                            PhoneNumber = "(555) 890-1234"
                        },
                        new
                        {
                            CustomerId = 29,
                            Address = "808 Elm St, Mountainview, USA",
                            Email = "kenneth.gonzalez@example.com",
                            FirstName = "Kenneth",
                            LastName = "Gonzalez",
                            PhoneNumber = "(555) 901-2345"
                        },
                        new
                        {
                            CustomerId = 30,
                            Address = "909 Oak St, Beachtown, USA",
                            Email = "margaret.wilson@example.com",
                            FirstName = "Margaret",
                            LastName = "Wilson",
                            PhoneNumber = "(555) 012-3456"
                        },
                        new
                        {
                            CustomerId = 31,
                            Address = "101 Maple Ave, Cityville, USA",
                            Email = "karen.martinez@example.com",
                            FirstName = "Karen",
                            LastName = "Martinez",
                            PhoneNumber = "(555) 123-4567"
                        },
                        new
                        {
                            CustomerId = 32,
                            Address = "202 Cedar St, Townsville, USA",
                            Email = "anthony.hernandez@example.com",
                            FirstName = "Anthony",
                            LastName = "Hernandez",
                            PhoneNumber = "(555) 234-5678"
                        },
                        new
                        {
                            CustomerId = 33,
                            Address = "303 Elm St, Hillside, USA",
                            Email = "sharon.lopez@example.com",
                            FirstName = "Sharon",
                            LastName = "Lopez",
                            PhoneNumber = "(555) 345-6789"
                        },
                        new
                        {
                            CustomerId = 34,
                            Address = "404 Pine St, Countryside, USA",
                            Email = "gary.gonzalez@example.com",
                            FirstName = "Gary",
                            LastName = "Gonzalez",
                            PhoneNumber = "(555) 456-7890"
                        },
                        new
                        {
                            CustomerId = 35,
                            Address = "505 Cedar St, Riverside, USA",
                            Email = "deborah.taylor@example.com",
                            FirstName = "Deborah",
                            LastName = "Taylor",
                            PhoneNumber = "(555) 567-8901"
                        },
                        new
                        {
                            CustomerId = 36,
                            Address = "606 Oak St, Suburbia, USA",
                            Email = "edward.martinez@example.com",
                            FirstName = "Edward",
                            LastName = "Martinez",
                            PhoneNumber = "(555) 678-9012"
                        },
                        new
                        {
                            CustomerId = 37,
                            Address = "707 Elm St, Lakeside, USA",
                            Email = "kimberly.hernandez@example.com",
                            FirstName = "Kimberly",
                            LastName = "Hernandez",
                            PhoneNumber = "(555) 789-0123"
                        },
                        new
                        {
                            CustomerId = 38,
                            Address = "808 Cedar St, Beachside, USA",
                            Email = "steven.lopez@example.com",
                            FirstName = "Steven",
                            LastName = "Lopez",
                            PhoneNumber = "(555) 890-1234"
                        },
                        new
                        {
                            CustomerId = 39,
                            Address = "909 Elm St, Mountainview, USA",
                            Email = "susan.gonzalez@example.com",
                            FirstName = "Susan",
                            LastName = "Gonzalez",
                            PhoneNumber = "(555) 901-2345"
                        },
                        new
                        {
                            CustomerId = 40,
                            Address = "101 Pine St, Beachtown, USA",
                            Email = "brian.wilson@example.com",
                            FirstName = "Brian",
                            LastName = "Wilson",
                            PhoneNumber = "(555) 012-3456"
                        },
                        new
                        {
                            CustomerId = 41,
                            Address = "202 Maple Ave, Cityville, USA",
                            Email = "elizabeth.martinez@example.com",
                            FirstName = "Elizabeth",
                            LastName = "Martinez",
                            PhoneNumber = "(555) 123-4567"
                        },
                        new
                        {
                            CustomerId = 42,
                            Address = "303 Oak St, Townsville, USA",
                            Email = "charles.hernandez@example.com",
                            FirstName = "Charles",
                            LastName = "Hernandez",
                            PhoneNumber = "(555) 234-5678"
                        },
                        new
                        {
                            CustomerId = 43,
                            Address = "404 Elm St, Hillside, USA",
                            Email = "donna.lopez@example.com",
                            FirstName = "Donna",
                            LastName = "Lopez",
                            PhoneNumber = "(555) 345-6789"
                        },
                        new
                        {
                            CustomerId = 44,
                            Address = "505 Cedar St, Countryside, USA",
                            Email = "david.gonzalez@example.com",
                            FirstName = "David",
                            LastName = "Gonzalez",
                            PhoneNumber = "(555) 456-7890"
                        },
                        new
                        {
                            CustomerId = 45,
                            Address = "606 Maple St, Riverside, USA",
                            Email = "jennifer.taylor@example.com",
                            FirstName = "Jennifer",
                            LastName = "Taylor",
                            PhoneNumber = "(555) 567-8901"
                        },
                        new
                        {
                            CustomerId = 46,
                            Address = "707 Elm St, Suburbia, USA",
                            Email = "michael.martinez@example.com",
                            FirstName = "Michael",
                            LastName = "Martinez",
                            PhoneNumber = "(555) 678-9012"
                        },
                        new
                        {
                            CustomerId = 47,
                            Address = "808 Pine St, Lakeside, USA",
                            Email = "barbara.hernandez@example.com",
                            FirstName = "Barbara",
                            LastName = "Hernandez",
                            PhoneNumber = "(555) 789-0123"
                        },
                        new
                        {
                            CustomerId = 48,
                            Address = "909 Oak St, Beachside, USA",
                            Email = "john.lopez@example.com",
                            FirstName = "John",
                            LastName = "Lopez",
                            PhoneNumber = "(555) 890-1234"
                        },
                        new
                        {
                            CustomerId = 49,
                            Address = "101 Cedar St, Mountainview, USA",
                            Email = "jessica.gonzalez@example.com",
                            FirstName = "Jessica",
                            LastName = "Gonzalez",
                            PhoneNumber = "(555) 901-2345"
                        },
                        new
                        {
                            CustomerId = 50,
                            Address = "202 Pine St, Smalltown, USA",
                            Email = "jason.taylor@example.com",
                            FirstName = "Jason",
                            LastName = "Taylor",
                            PhoneNumber = "(555) 012-3456"
                        });
                });

            modelBuilder.Entity("BurgerAppDomain.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BurgerAppDomain.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BurgerAppDomain.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BurgerAppDomain.Order", b =>
                {
                    b.HasOne("BurgerAppDomain.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BurgerAppDomain.OrderDetail", b =>
                {
                    b.HasOne("BurgerAppDomain.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerAppDomain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
