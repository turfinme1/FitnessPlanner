using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMuscleGroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "muscle_group",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Neck" },
                    { 2, "Trapezius" },
                    { 3, "Shoulder" },
                    { 4, "Chest" },
                    { 5, "Back" },
                    { 6, "Biceps" },
                    { 7, "Triceps" },
                    { 8, "Forearm" },
                    { 9, "Abs" },
                    { 10, "Legs" },
                    { 11, "Calves" },
                    { 12, "Full Body" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "muscle_group",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "muscle_group",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "muscle_group",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "muscle_group",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "muscle_group",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "muscle_group",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "muscle_group",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "muscle_group",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "muscle_group",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "muscle_group",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "muscle_group",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "muscle_group",
                keyColumn: "id",
                keyValue: 12);
        }
    }
}
