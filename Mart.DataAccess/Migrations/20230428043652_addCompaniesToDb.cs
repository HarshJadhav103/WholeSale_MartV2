using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mart.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCompaniesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Name", "PhoneNumber", "PostalCode", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 2, "Ahmedabad", "Harsh Pvt. Ltd.", "7048429818", "396125", "Gujarat", "15, Premchandnagar Society, Bodekdev" },
                    { 3, "Bharuch", "Vicky Pvt. Ltd.", "9979619688", "396123", "Gujarat", "15, Askray Society, Bholav" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
