using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedSkillLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "skill_level",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Beginner" },
                    { 2, "Intermediate" },
                    { 3, "Advanced" },
                    { 4, "Professional" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "skill_level",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "skill_level",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "skill_level",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "skill_level",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
