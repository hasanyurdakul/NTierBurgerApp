using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurgerAppDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "123 Main St, Anytown, USA", "john.doe@example.com", "John", "Doe", "(555) 123-4567" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "456 Elm St, Smalltown, USA", "emily.smith@example.com", "Emily", "Smith", "(555) 234-5678" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "789 Oak St, Cityville, USA", "michael.johnson@example.com", "Michael", "Johnson", "(555) 345-6789" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "101 Maple Ave, Villagetown, USA", "sarah.williams@example.com", "Sarah", "Williams", "(555) 456-7890" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "202 Cedar St, Townsville, USA", "christopher.brown@example.com", "Christopher", "Brown", "(555) 567-8901" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "İstanbul", "hasan@gmail.com", "Hasan", "Yurdakul", "5555555555" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Ankara", "john@gmail.com", "John", "Doe", "5555555555" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "İzmir", "jane@gmail.com", "Jane", "Thompson", "5555555555" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Bursa", "dana@gmail.com", "Dana", "Ahern", "5555555555" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "Address", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Antalya", "carol@gmail.com", "Carol", "Jackson", "5555555555" });
        }
    }
}
