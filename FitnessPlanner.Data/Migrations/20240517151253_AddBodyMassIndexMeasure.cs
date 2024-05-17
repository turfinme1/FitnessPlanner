using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBodyMassIndexMeasure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_goal_GoalId",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_user_skill_level_SkillLevelId",
                table: "user");

            migrationBuilder.RenameColumn(
                name: "SkillLevelId",
                table: "user",
                newName: "skill_level_id");

            migrationBuilder.RenameColumn(
                name: "GoalId",
                table: "user",
                newName: "goal_id");

            migrationBuilder.RenameIndex(
                name: "IX_user_SkillLevelId",
                table: "user",
                newName: "IX_user_skill_level_id");

            migrationBuilder.RenameIndex(
                name: "IX_user_GoalId",
                table: "user",
                newName: "IX_user_goal_id");

            migrationBuilder.AddColumn<int>(
                name: "body_mass_index_measure_id",
                table: "user",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "body_mass_index_measure",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_body_mass_index_measure", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "workout_plan_body_mass_index_measure",
                columns: table => new
                {
                    workout_plan_id = table.Column<int>(type: "integer", nullable: false),
                    body_mass_index_measure_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workout_plan_body_mass_index_measure", x => new { x.workout_plan_id, x.body_mass_index_measure_id });
                    table.ForeignKey(
                        name: "FK_workout_plan_body_mass_index_measure_body_mass_index_measur~",
                        column: x => x.body_mass_index_measure_id,
                        principalTable: "body_mass_index_measure",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_workout_plan_body_mass_index_measure_workout_plan_workout_p~",
                        column: x => x.workout_plan_id,
                        principalTable: "workout_plan",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "body_mass_index_measure",
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

            migrationBuilder.CreateIndex(
                name: "IX_user_body_mass_index_measure_id",
                table: "user",
                column: "body_mass_index_measure_id");

            migrationBuilder.CreateIndex(
                name: "IX_workout_plan_body_mass_index_measure_body_mass_index_measur~",
                table: "workout_plan_body_mass_index_measure",
                column: "body_mass_index_measure_id");

            migrationBuilder.AddForeignKey(
                name: "FK_user_body_mass_index_measure_body_mass_index_measure_id",
                table: "user",
                column: "body_mass_index_measure_id",
                principalTable: "body_mass_index_measure",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_user_goal_goal_id",
                table: "user",
                column: "goal_id",
                principalTable: "goal",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_user_skill_level_skill_level_id",
                table: "user",
                column: "skill_level_id",
                principalTable: "skill_level",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_body_mass_index_measure_body_mass_index_measure_id",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_user_goal_goal_id",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_user_skill_level_skill_level_id",
                table: "user");

            migrationBuilder.DropTable(
                name: "workout_plan_body_mass_index_measure");

            migrationBuilder.DropTable(
                name: "body_mass_index_measure");

            migrationBuilder.DropIndex(
                name: "IX_user_body_mass_index_measure_id",
                table: "user");

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

            migrationBuilder.DropColumn(
                name: "body_mass_index_measure_id",
                table: "user");

            migrationBuilder.RenameColumn(
                name: "skill_level_id",
                table: "user",
                newName: "SkillLevelId");

            migrationBuilder.RenameColumn(
                name: "goal_id",
                table: "user",
                newName: "GoalId");

            migrationBuilder.RenameIndex(
                name: "IX_user_skill_level_id",
                table: "user",
                newName: "IX_user_SkillLevelId");

            migrationBuilder.RenameIndex(
                name: "IX_user_goal_id",
                table: "user",
                newName: "IX_user_GoalId");

            migrationBuilder.AddForeignKey(
                name: "FK_user_goal_GoalId",
                table: "user",
                column: "GoalId",
                principalTable: "goal",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_user_skill_level_SkillLevelId",
                table: "user",
                column: "SkillLevelId",
                principalTable: "skill_level",
                principalColumn: "id");
        }
    }
}
