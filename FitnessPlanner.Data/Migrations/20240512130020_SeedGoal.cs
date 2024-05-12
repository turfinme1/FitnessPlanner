using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedGoal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "goal",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Lose weight" },
                    { 2, "Gain muscle" },
                    { 3, "Maintain weight" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "goal",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "goal",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "goal",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
