﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurgerAppDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123 Main St, Anytown, USA", "john.doe@example.com", "John", "Doe", "(555) 123-4567" },
                    { 2, "456 Elm St, Smalltown, USA", "emily.smith@example.com", "Emily", "Smith", "(555) 234-5678" },
                    { 3, "789 Oak St, Cityville, USA", "michael.johnson@example.com", "Michael", "Johnson", "(555) 345-6789" },
                    { 4, "101 Maple Ave, Villagetown, USA", "sarah.williams@example.com", "Sarah", "Williams", "(555) 456-7890" },
                    { 5, "202 Cedar St, Townsville, USA", "christopher.brown@example.com", "Christopher", "Brown", "(555) 567-8901" },
                    { 6, "303 Pine St, Hamletville, USA", "jessica.davis@example.com", "Jessica", "Davis", "(555) 678-9012" },
                    { 7, "404 Birch St, Suburbia, USA", "matthew.miller@example.com", "Matthew", "Miller", "(555) 789-0123" },
                    { 8, "505 Walnut St, Riverside, USA", "ashley.wilson@example.com", "Ashley", "Wilson", "(555) 890-1234" },
                    { 9, "606 Oak St, Hillside, USA", "daniel.moore@example.com", "Daniel", "Moore", "(555) 901-2345" },
                    { 10, "707 Maple St, Lakeside, USA", "amanda.taylor@example.com", "Amanda", "Taylor", "(555) 012-3456" },
                    { 11, "808 Pine St, Mountainview, USA", "robert.martinez@example.com", "Robert", "Martinez", "(555) 123-4567" },
                    { 12, "909 Cedar St, Beachtown, USA", "jennifer.hernandez@example.com", "Jennifer", "Hernandez", "(555) 234-5678" },
                    { 13, "111 Birch St, Countryside, USA", "james.lopez@example.com", "James", "Lopez", "(555) 345-6789" },
                    { 14, "222 Elm St, Riverside, USA", "mary.gonzalez@example.com", "Mary", "Gonzalez", "(555) 456-7890" },
                    { 15, "333 Oak St, Suburbia, USA", "david.wilson@example.com", "David", "Wilson", "(555) 567-8901" },
                    { 16, "444 Maple St, Cityville, USA", "maria.taylor@example.com", "Maria", "Taylor", "(555) 678-9012" },
                    { 17, "555 Pine St, Hillside, USA", "charles.martinez@example.com", "Charles", "Martinez", "(555) 789-0123" },
                    { 18, "666 Cedar St, Townsville, USA", "patricia.hernandez@example.com", "Patricia", "Hernandez", "(555) 890-1234" },
                    { 19, "777 Birch St, Lakeside, USA", "richard.lopez@example.com", "Richard", "Lopez", "(555) 901-2345" },
                    { 20, "888 Elm St, Beachside, USA", "linda.gonzalez@example.com", "Linda", "Gonzalez", "(555) 012-3456" },
                    { 21, "999 Pine St, Citytown, USA", "thomas.martinez@example.com", "Thomas", "Martinez", "(555) 123-4567" },
                    { 22, "101 Oak St, Countryside, USA", "karen.hernandez@example.com", "Karen", "Hernandez", "(555) 234-5678" },
                    { 23, "202 Cedar St, Riverside, USA", "steven.lopez@example.com", "Steven", "Lopez", "(555) 345-6789" },
                    { 24, "303 Elm St, Suburbia, USA", "barbara.gonzalez@example.com", "Barbara", "Gonzalez", "(555) 456-7890" },
                    { 25, "404 Maple St, Hillside, USA", "joseph.taylor@example.com", "Joseph", "Taylor", "(555) 567-8901" },
                    { 26, "505 Pine St, Lakeside, USA", "donna.martinez@example.com", "Donna", "Martinez", "(555) 678-9012" },
                    { 27, "606 Oak St, Beachside, USA", "ronald.hernandez@example.com", "Ronald", "Hernandez", "(555) 789-0123" },
                    { 28, "707 Cedar St, Smalltown, USA", "laura.lopez@example.com", "Laura", "Lopez", "(555) 890-1234" },
                    { 29, "808 Elm St, Mountainview, USA", "kenneth.gonzalez@example.com", "Kenneth", "Gonzalez", "(555) 901-2345" },
                    { 30, "909 Oak St, Beachtown, USA", "margaret.wilson@example.com", "Margaret", "Wilson", "(555) 012-3456" },
                    { 31, "101 Maple Ave, Cityville, USA", "karen.martinez@example.com", "Karen", "Martinez", "(555) 123-4567" },
                    { 32, "202 Cedar St, Townsville, USA", "anthony.hernandez@example.com", "Anthony", "Hernandez", "(555) 234-5678" },
                    { 33, "303 Elm St, Hillside, USA", "sharon.lopez@example.com", "Sharon", "Lopez", "(555) 345-6789" },
                    { 34, "404 Pine St, Countryside, USA", "gary.gonzalez@example.com", "Gary", "Gonzalez", "(555) 456-7890" },
                    { 35, "505 Cedar St, Riverside, USA", "deborah.taylor@example.com", "Deborah", "Taylor", "(555) 567-8901" },
                    { 36, "606 Oak St, Suburbia, USA", "edward.martinez@example.com", "Edward", "Martinez", "(555) 678-9012" },
                    { 37, "707 Elm St, Lakeside, USA", "kimberly.hernandez@example.com", "Kimberly", "Hernandez", "(555) 789-0123" },
                    { 38, "808 Cedar St, Beachside, USA", "steven.lopez@example.com", "Steven", "Lopez", "(555) 890-1234" },
                    { 39, "909 Elm St, Mountainview, USA", "susan.gonzalez@example.com", "Susan", "Gonzalez", "(555) 901-2345" },
                    { 40, "101 Pine St, Beachtown, USA", "brian.wilson@example.com", "Brian", "Wilson", "(555) 012-3456" },
                    { 41, "202 Maple Ave, Cityville, USA", "elizabeth.martinez@example.com", "Elizabeth", "Martinez", "(555) 123-4567" },
                    { 42, "303 Oak St, Townsville, USA", "charles.hernandez@example.com", "Charles", "Hernandez", "(555) 234-5678" },
                    { 43, "404 Elm St, Hillside, USA", "donna.lopez@example.com", "Donna", "Lopez", "(555) 345-6789" },
                    { 44, "505 Cedar St, Countryside, USA", "david.gonzalez@example.com", "David", "Gonzalez", "(555) 456-7890" },
                    { 45, "606 Maple St, Riverside, USA", "jennifer.taylor@example.com", "Jennifer", "Taylor", "(555) 567-8901" },
                    { 46, "707 Elm St, Suburbia, USA", "michael.martinez@example.com", "Michael", "Martinez", "(555) 678-9012" },
                    { 47, "808 Pine St, Lakeside, USA", "barbara.hernandez@example.com", "Barbara", "Hernandez", "(555) 789-0123" },
                    { 48, "909 Oak St, Beachside, USA", "john.lopez@example.com", "John", "Lopez", "(555) 890-1234" },
                    { 49, "101 Cedar St, Mountainview, USA", "jessica.gonzalez@example.com", "Jessica", "Gonzalez", "(555) 901-2345" },
                    { 50, "202 Pine St, Smalltown, USA", "jason.taylor@example.com", "Jason", "Taylor", "(555) 012-3456" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "OrderDate", "Status" },
                values: new object[,]
                {
                    { 1, 43, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 2, 46, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 3, 18, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 4, 11, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 5, 20, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 6, 19, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 7, 24, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 8, 30, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 9, 12, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 10, 29, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 11, 21, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 12, 42, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 13, 11, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 14, 13, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 15, 34, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 16, 39, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 17, 23, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 18, 33, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 19, 14, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 20, 7, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 21, 36, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 22, 13, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 23, 43, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 24, 39, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 25, 6, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 26, 29, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 27, 39, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 28, 37, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 29, 19, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 30, 18, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 31, 24, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 32, 10, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 33, 50, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 34, 27, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 35, 34, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 36, 41, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 37, 14, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 38, 39, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 39, 26, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 40, 10, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 41, 46, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 42, 39, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 43, 20, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 44, 5, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 45, 35, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 46, 37, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 47, 2, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed" },
                    { 48, 24, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 49, 24, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" },
                    { 50, 14, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Preparing" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
