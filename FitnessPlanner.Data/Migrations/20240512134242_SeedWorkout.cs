using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedWorkout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "exercise_perform_info",
                columns: new[] { "id", "exercise_id", "reps", "sets" },
                values: new object[,]
                {
                    { 1, 73, 5, 3 },
                    { 2, 18, 5, 3 },
                    { 3, 86, 5, 3 },
                    { 4, 50, 5, 3 },
                    { 5, 8, 5, 3 },
                    { 6, 57, 5, 3 },
                    { 7, 38, 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "single_workout",
                columns: new[] { "id", "day", "name" },
                values: new object[,]
                {
                    { 1, 1, "Full Body type A" },
                    { 2, 3, "Full Body type B" },
                    { 3, 5, "Full Body type A" }
                });

            migrationBuilder.InsertData(
                table: "workout_plan",
                columns: new[] { "id", "goal_id", "name", "skill_level_id", "user_id" },
                values: new object[] { 1, 1, "Beginner muscle gain full body workout", 2, null });

            migrationBuilder.InsertData(
                table: "exercise_perform_info_single_workout",
                columns: new[] { "exercise_perform_info_id", "single_workout_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 3 },
                    { 4, 1 },
                    { 4, 3 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 }
                });

            migrationBuilder.InsertData(
                table: "single_workout_workout_plan",
                columns: new[] { "single_workout_id", "workout_plan_id" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "workout_plan_body_mass_index_measure",
                columns: new[] { "body_mass_index_measure_id", "workout_plan_id" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "exercise_perform_info_single_workout",
                keyColumns: new[] { "exercise_perform_info_id", "single_workout_id" },
                keyValues: new object[] { 7, 2 });

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
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "exercise_perform_info",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "single_workout",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "workout_plan",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
