using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCrossTableExerciseMuscleGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "exercises_muscle_group",
                columns: new[] { "exercise_id", "muscle_group_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 3 },
                    { 9, 3 },
                    { 10, 3 },
                    { 11, 3 },
                    { 12, 3 },
                    { 13, 3 },
                    { 14, 3 },
                    { 15, 3 },
                    { 16, 3 },
                    { 17, 3 },
                    { 18, 4 },
                    { 19, 4 },
                    { 20, 4 },
                    { 21, 4 },
                    { 22, 4 },
                    { 23, 4 },
                    { 24, 4 },
                    { 25, 4 },
                    { 26, 4 },
                    { 27, 4 },
                    { 28, 5 },
                    { 29, 5 },
                    { 30, 5 },
                    { 31, 5 },
                    { 32, 5 },
                    { 33, 5 },
                    { 34, 5 },
                    { 35, 5 },
                    { 36, 5 },
                    { 37, 5 },
                    { 38, 6 },
                    { 39, 6 },
                    { 40, 6 },
                    { 41, 6 },
                    { 42, 6 },
                    { 43, 6 },
                    { 44, 6 },
                    { 45, 6 },
                    { 46, 6 },
                    { 47, 6 },
                    { 48, 7 },
                    { 49, 7 },
                    { 50, 7 },
                    { 51, 7 },
                    { 52, 7 },
                    { 53, 7 },
                    { 54, 7 },
                    { 55, 7 },
                    { 56, 7 },
                    { 57, 7 },
                    { 58, 8 },
                    { 59, 8 },
                    { 60, 8 },
                    { 61, 8 },
                    { 62, 8 },
                    { 63, 9 },
                    { 64, 9 },
                    { 65, 9 },
                    { 66, 9 },
                    { 67, 9 },
                    { 68, 9 },
                    { 69, 9 },
                    { 70, 9 },
                    { 71, 9 },
                    { 72, 9 },
                    { 73, 10 },
                    { 74, 10 },
                    { 75, 10 },
                    { 76, 10 },
                    { 77, 10 },
                    { 78, 10 },
                    { 79, 10 },
                    { 80, 10 },
                    { 81, 10 },
                    { 82, 10 },
                    { 83, 11 },
                    { 84, 11 },
                    { 85, 12 },
                    { 86, 12 },
                    { 87, 12 },
                    { 88, 12 },
                    { 89, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 12, 3 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 16, 3 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 17, 3 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 18, 4 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 19, 4 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 22, 4 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 23, 4 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 24, 4 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 25, 4 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 26, 4 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 27, 4 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 28, 5 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 29, 5 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 30, 5 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 31, 5 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 32, 5 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 33, 5 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 34, 5 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 35, 5 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 36, 5 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 37, 5 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 38, 6 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 39, 6 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 40, 6 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 41, 6 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 42, 6 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 43, 6 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 44, 6 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 45, 6 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 46, 6 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 47, 6 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 48, 7 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 49, 7 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 50, 7 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 51, 7 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 52, 7 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 53, 7 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 54, 7 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 55, 7 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 56, 7 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 57, 7 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 58, 8 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 59, 8 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 60, 8 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 61, 8 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 62, 8 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 63, 9 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 64, 9 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 65, 9 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 66, 9 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 67, 9 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 68, 9 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 69, 9 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 70, 9 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 71, 9 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 72, 9 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 73, 10 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 74, 10 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 75, 10 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 76, 10 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 77, 10 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 78, 10 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 79, 10 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 80, 10 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 81, 10 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 82, 10 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 83, 11 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 84, 11 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 85, 12 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 86, 12 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 87, 12 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 88, 12 });

            migrationBuilder.DeleteData(
                table: "exercises_muscle_group",
                keyColumns: new[] { "exercise_id", "muscle_group_id" },
                keyValues: new object[] { 89, 12 });
        }
    }
}
