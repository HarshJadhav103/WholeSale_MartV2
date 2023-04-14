using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mart.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductNumber = table.Column<int>(type: "int", nullable: false),
                    VedorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price10 = table.Column<double>(type: "float", nullable: false),
                    Price25 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "OriginalPrice", "Price", "Price10", "Price25", "ProductName", "ProductNumber", "VedorName" },
                values: new object[,]
                {
                    { 1, "Set of 6 stainless steel spoons in Lowest Price", 600.0, 550.0, 500.0, 450.0, "Spoon", 1234, "Harsh" },
                    { 2, "Set of 12 Caps in Lowest Price", 1200.0, 1100.0, 950.0, 850.0, "Caps", 5678, "Vicky" },
                    { 3, "Set of 12 Socks in Lowest Price", 1000.0, 900.0, 850.0, 800.0, "Socks", 5679, "Vicky" },
                    { 4, "Set of 50 disposable Paper plates", 100.0, 80.0, 75.0, 70.0, "Paper Plates", 1236, "Nandit" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
