using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationshipBetweenUserAndWorkoutPlanAsManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user_workout_plan",
                columns: table => new
                {
                    user_id = table.Column<string>(type: "text", nullable: false, comment: "The ID of the associated user."),
                    workout_plan_id = table.Column<int>(type: "integer", nullable: false, comment: "The ID of the associated workout plan.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_workout_plan", x => new { x.user_id, x.workout_plan_id });
                    table.ForeignKey(
                        name: "FK_user_workout_plan_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_workout_plan_workout_plan_workout_plan_id",
                        column: x => x.workout_plan_id,
                        principalTable: "workout_plan",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_user_workout_plan_workout_plan_id",
                table: "user_workout_plan",
                column: "workout_plan_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_workout_plan");
        }
    }
}
