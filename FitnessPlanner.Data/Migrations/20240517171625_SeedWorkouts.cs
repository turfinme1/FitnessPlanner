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
                    { 20, 72, 10, 3 }
                });

            migrationBuilder.InsertData(
                table: "single_workout",
                columns: new[] { "id", "day", "name" },
                values: new object[,]
                {
                    { 4, 1, "Full Body Strength Training" },
                    { 5, 2, "Cardio and Core" },
                    { 6, 4, "Full Body Strength Training" },
                    { 7, 5, "Cardio and Core" }
                });

            migrationBuilder.InsertData(
                table: "workout_plan",
                columns: new[] { "id", "goal_id", "name", "skill_level_id", "user_id" },
                values: new object[,]
                {
                    { 1, 1, "Beginner muscle gain full body workout", 1, null },
                    { 2, 1, "Beginner body toning workout for women", 1, null }
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
                    { 20, 7 }
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
                    { 7, 2 }
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
                    { 6, 2 }
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
                table: "workout_plan",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "workout_plan",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
