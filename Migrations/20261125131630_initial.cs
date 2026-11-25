using Microsoft.EntityFrameworkCore.Migrations;
// cspell:ignore Npgsql
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace training_proj.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    RacingNumber = table.Column<int>(type: "integer", nullable: false),
                    Team = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Name", "RacingNumber", "Team" },
                values: new object[,]
                {
                    { 1, "Max Verstappen", 1, "Red Bull Racing" },
                    { 2, "Lewis Hamilton", 44, "Ferrari" },
                    { 3, "Charles Leclerc", 16, "Ferrari" },
                    { 4, "Lando Norris", 4, "McLaren" },
                    { 5, "Oscar Piastri", 81, "McLaren" },
                    { 6, "Carlos Sainz", 55, "Williams" },
                    { 7, "George Russell", 63, "Mercedes" },
                    { 8, "Sergio Perez", 11, "Red Bull Racing" },
                    { 9, "Fernando Alonso", 14, "Aston Martin" },
                    { 10, "Lance Stroll", 18, "Aston Martin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
