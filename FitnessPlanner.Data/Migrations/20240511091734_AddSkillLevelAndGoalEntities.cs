using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSkillLevelAndGoalEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_rest_day",
                table: "single_workout");

            migrationBuilder.AddColumn<int>(
                name: "goal_id",
                table: "workout_plan",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "skill_level_id",
                table: "workout_plan",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoalId",
                table: "user",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SkillLevelId",
                table: "user",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "goal",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_goal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "skill_level",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skill_level", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_workout_plan_goal_id",
                table: "workout_plan",
                column: "goal_id");

            migrationBuilder.CreateIndex(
                name: "IX_workout_plan_skill_level_id",
                table: "workout_plan",
                column: "skill_level_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_GoalId",
                table: "user",
                column: "GoalId");

            migrationBuilder.CreateIndex(
                name: "IX_user_SkillLevelId",
                table: "user",
                column: "SkillLevelId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_workout_plan_goal_goal_id",
                table: "workout_plan",
                column: "goal_id",
                principalTable: "goal",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_workout_plan_skill_level_skill_level_id",
                table: "workout_plan",
                column: "skill_level_id",
                principalTable: "skill_level",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_goal_GoalId",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_user_skill_level_SkillLevelId",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_workout_plan_goal_goal_id",
                table: "workout_plan");

            migrationBuilder.DropForeignKey(
                name: "FK_workout_plan_skill_level_skill_level_id",
                table: "workout_plan");

            migrationBuilder.DropTable(
                name: "goal");

            migrationBuilder.DropTable(
                name: "skill_level");

            migrationBuilder.DropIndex(
                name: "IX_workout_plan_goal_id",
                table: "workout_plan");

            migrationBuilder.DropIndex(
                name: "IX_workout_plan_skill_level_id",
                table: "workout_plan");

            migrationBuilder.DropIndex(
                name: "IX_user_GoalId",
                table: "user");

            migrationBuilder.DropIndex(
                name: "IX_user_SkillLevelId",
                table: "user");

            migrationBuilder.DropColumn(
                name: "goal_id",
                table: "workout_plan");

            migrationBuilder.DropColumn(
                name: "skill_level_id",
                table: "workout_plan");

            migrationBuilder.DropColumn(
                name: "GoalId",
                table: "user");

            migrationBuilder.DropColumn(
                name: "SkillLevelId",
                table: "user");

            migrationBuilder.AddColumn<bool>(
                name: "is_rest_day",
                table: "single_workout",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
