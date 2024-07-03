using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedWorkouts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "workout_plan",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "exercise_perform_info",
                columns: new[] { "id", "exercise_id", "reps", "sets" },
                values: new object[,]
                {
                    { 8, 73, 12, 3 },
                    { 9, 9, 12, 3 },
                    { 10, 32, 12, 3 },
                    { 11, 43, 12, 3 },
                    { 12, 30, 12, 3 },
                    { 13, 77, 12, 3 },
                    { 14, 83, 15, 3 },
                    { 15, 81, 15, 3 },
                    { 16, 85, 30, 3 },
                    { 17, 66, 30, 3 },
                    { 18, 68, 15, 3 },
                    { 19, 70, 12, 3 },
                    { 20, 72, 10, 3 },
                    { 21, 32, 8, 4 },
                    { 22, 86, 8, 4 },
                    { 23, 29, 8, 4 },
                    { 24, 40, 8, 4 },
                    { 25, 39, 12, 4 },
                    { 26, 42, 12, 4 },
                    { 27, 18, 8, 4 },
                    { 28, 19, 8, 4 },
                    { 29, 8, 8, 4 },
                    { 30, 55, 8, 4 },
                    { 31, 5, 12, 4 },
                    { 32, 48, 12, 4 },
                    { 33, 34, 8, 4 },
                    { 34, 73, 8, 4 },
                    { 35, 75, 12, 4 },
                    { 36, 76, 12, 4 },
                    { 37, 84, 15, 4 },
                    { 38, 18, 6, 4 },
                    { 39, 19, 6, 4 },
                    { 40, 8, 6, 4 },
                    { 41, 23, 8, 4 },
                    { 42, 9, 8, 4 },
                    { 43, 10, 10, 4 },
                    { 44, 5, 10, 4 },
                    { 45, 29, 6, 4 },
                    { 46, 32, 6, 4 },
                    { 47, 86, 6, 4 },
                    { 48, 30, 8, 4 },
                    { 49, 14, 10, 4 },
                    { 50, 48, 10, 4 },
                    { 51, 40, 8, 4 },
                    { 52, 73, 6, 4 },
                    { 53, 34, 6, 4 },
                    { 54, 74, 8, 4 },
                    { 55, 75, 10, 4 },
                    { 56, 76, 12, 4 },
                    { 57, 77, 12, 4 },
                    { 58, 83, 15, 4 },
                    { 59, 24, 10, 3 },
                    { 60, 32, 10, 3 },
                    { 61, 9, 10, 3 },
                    { 62, 73, 10, 3 },
                    { 63, 77, 15, 3 },
                    { 64, 85, 30, 3 },
                    { 65, 25, 10, 3 },
                    { 66, 31, 10, 3 },
                    { 67, 23, 10, 3 },
                    { 68, 74, 10, 3 },
                    { 69, 76, 15, 3 },
                    { 70, 17, 15, 3 },
                    { 71, 20, 10, 3 },
                    { 72, 29, 10, 3 },
                    { 73, 10, 15, 3 },
                    { 74, 82, 12, 3 },
                    { 75, 83, 15, 3 },
                    { 76, 66, 30, 3 }
                });

            migrationBuilder.InsertData(
                table: "single_workout",
                columns: new[] { "id", "day", "name" },
                values: new object[,]
                {
                    { 4, 1, "Full Body Strength Training" },
                    { 5, 2, "Cardio and Core" },
                    { 6, 4, "Full Body Strength Training" },
                    { 7, 5, "Cardio and Core" },
                    { 8, 1, "Pull" },
                    { 9, 3, "Push" },
                    { 10, 5, "Legs" },
                    { 11, 1, "Push" },
                    { 12, 2, "Pull" },
                    { 13, 3, "Legs" },
                    { 14, 5, "Push" },
                    { 15, 6, "Pull" },
                    { 16, 7, "Leg" },
                    { 17, 1, "Full Body A" },
                    { 18, 3, "Full Body B" },
                    { 19, 5, "Full Body C" }
                });

            migrationBuilder.InsertData(
                table: "workout_plan",
                columns: new[] { "id", "goal_id", "name", "skill_level_id", "user_id" },
                values: new object[,]
                {
                    { 1, 2, "Beginner muscle gain full body workout plan", 1, null },
                    { 2, 1, "Beginner body toning workout plan for women", 1, null },
                    { 3, 2, "Push pull legs workout plan for intermediate lifters", 2, null },
                    { 4, 2, "Push pull legs workout plan for advanced lifters", 3, null },
                    { 5, 1, "Beginner weight loss plan", 1, null }
                });

            migrationBuilder.InsertData(
                table: "exercise_perform_info_single_workout",
                columns: new[] { "exercise_perform_info_id", "single_workout_id" },
                values: new object[,]
                {
                    { 8, 4 },
                    { 8, 6 },
                    { 9, 4 },
                    { 9, 6 },
                    { 10, 4 },
                    { 10, 6 },
                    { 11, 4 },
                    { 11, 6 },
                    { 12, 4 },
                    { 12, 6 },
                    { 13, 4 },
                    { 13, 6 },
                    { 14, 4 },
                    { 15, 5 },
                    { 15, 7 },
                    { 16, 5 },
                    { 16, 7 },
                    { 17, 5 },
                    { 17, 7 },
                    { 18, 5 },
                    { 18, 7 },
                    { 19, 5 },
                    { 19, 7 },
                    { 20, 5 },
                    { 20, 7 },
                    { 21, 8 },
                    { 22, 8 },
                    { 23, 8 },
                    { 24, 8 },
                    { 25, 8 },
                    { 26, 8 },
                    { 27, 9 },
                    { 28, 9 },
                    { 29, 9 },
                    { 30, 9 },
                    { 31, 9 },
                    { 32, 9 },
                    { 33, 10 },
                    { 34, 10 },
                    { 35, 10 },
                    { 36, 10 },
                    { 37, 10 },
                    { 38, 11 },
                    { 38, 14 },
                    { 39, 11 },
                    { 39, 14 },
                    { 40, 11 },
                    { 40, 14 },
                    { 41, 11 },
                    { 41, 14 },
                    { 42, 11 },
                    { 42, 14 },
                    { 43, 11 },
                    { 43, 14 },
                    { 44, 11 },
                    { 44, 14 },
                    { 45, 12 },
                    { 45, 15 },
                    { 46, 12 },
                    { 46, 15 },
                    { 47, 12 },
                    { 47, 15 },
                    { 48, 12 },
                    { 48, 15 },
                    { 49, 12 },
                    { 49, 15 },
                    { 50, 12 },
                    { 50, 15 },
                    { 51, 12 },
                    { 51, 15 },
                    { 52, 13 },
                    { 52, 16 },
                    { 53, 13 },
                    { 53, 16 },
                    { 54, 13 },
                    { 54, 16 },
                    { 55, 13 },
                    { 55, 16 },
                    { 56, 13 },
                    { 56, 16 },
                    { 57, 13 },
                    { 57, 16 },
                    { 58, 13 },
                    { 58, 16 },
                    { 59, 17 },
                    { 60, 17 },
                    { 61, 17 },
                    { 62, 17 },
                    { 63, 17 },
                    { 64, 17 },
                    { 65, 18 },
                    { 66, 18 },
                    { 67, 18 },
                    { 68, 18 },
                    { 69, 18 },
                    { 70, 18 },
                    { 71, 19 },
                    { 72, 19 },
                    { 73, 19 },
                    { 74, 19 },
                    { 75, 19 },
                    { 76, 19 }
                });

            migrationBuilder.InsertData(
                table: "single_workout_workout_plan",
                columns: new[] { "single_workout_id", "workout_plan_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 3 },
                    { 9, 3 },
                    { 10, 3 },
                    { 11, 4 },
                    { 12, 4 },
                    { 13, 4 },
                    { 14, 4 },
                    { 15, 4 },
                    { 16, 4 },
                    { 17, 5 },
                    { 18, 5 },
                    { 19, 5 }
                });

            migrationBuilder.InsertData(
                table: "workout_plan_body_mass_index_measure",
                columns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 3, 3 },
                    { 4, 3 },
                    { 3, 4 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 5 },
                    { 6, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 9, 4 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 10, 6 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 11, 6 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 12, 6 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 13, 6 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 15, 7 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 16, 5 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 16, 7 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 17, 7 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 18, 7 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 19, 7 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 20, 7 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 21, 8 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 22, 8 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 23, 8 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 24, 8 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 25, 8 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 26, 8 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 27, 9 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 28, 9 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 29, 9 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 30, 9 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 31, 9 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 32, 9 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 33, 10 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 34, 10 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 35, 10 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 36, 10 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 37, 10 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 38, 11 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 38, 14 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 39, 11 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 39, 14 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 40, 11 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 40, 14 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 41, 11 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 41, 14 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 42, 11 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 42, 14 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 43, 11 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 43, 14 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 44, 11 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 44, 14 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 45, 12 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 45, 15 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 46, 12 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 46, 15 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 47, 12 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 47, 15 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 48, 12 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 48, 15 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 49, 12 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 49, 15 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 50, 12 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 50, 15 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 51, 12 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 51, 15 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 52, 13 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 52, 16 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 53, 13 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 53, 16 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 54, 13 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 54, 16 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 55, 13 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 55, 16 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 56, 13 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 56, 16 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 57, 13 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 57, 16 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 58, 13 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 58, 16 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 59, 17 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 60, 17 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 61, 17 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 62, 17 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 63, 17 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 64, 17 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 65, 18 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 66, 18 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 67, 18 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 68, 18 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 69, 18 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 70, 18 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 71, 19 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 72, 19 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 73, 19 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 74, 19 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 75, 19 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 76, 19 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 12, 4 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 15, 4 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 17, 5 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 18, 5 });

            migrationBuilder.DeleteData(
                table: "single_workout_workout_plan",
                keyColumns: new[] { "single_workout_id", "workout_plan_id" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "workout_plan_body_mass_index_measure",
                keyColumns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "workout_plan",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "workout_plan",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "workout_plan",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "workout_plan",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "workout_plan",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "workout_plan",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);
        }
    }
}
