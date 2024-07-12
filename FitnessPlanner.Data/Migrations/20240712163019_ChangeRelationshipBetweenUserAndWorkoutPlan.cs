using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeRelationshipBetweenUserAndWorkoutPlan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_workout_plan_user_id",
                table: "workout_plan");

            migrationBuilder.CreateIndex(
                name: "IX_workout_plan_user_id",
                table: "workout_plan",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_workout_plan_user_id",
                table: "workout_plan");

            migrationBuilder.CreateIndex(
                name: "IX_workout_plan_user_id",
                table: "workout_plan",
                column: "user_id",
                unique: true);
        }
    }
}
