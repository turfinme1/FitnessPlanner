using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedBodyMassIndexMeasure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "body_mass_index_measure_id",
                columns: new[] { "id", "type" },
                values: new object[,]
                {
                    { 1, "Severe Underweight" },
                    { 2, "Underweight" },
                    { 3, "Normal weight" },
                    { 4, "Slightly Above Normal weight" },
                    { 5, "Overweight" },
                    { 6, "Obesity" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "body_mass_index_measure_id",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "body_mass_index_measure_id",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "body_mass_index_measure_id",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "body_mass_index_measure_id",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "body_mass_index_measure_id",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "body_mass_index_measure_id",
                keyColumn: "id",
                keyValue: 6);
        }
    }
}
