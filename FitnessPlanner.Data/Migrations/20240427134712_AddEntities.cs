using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "exercise",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    explanation = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    perform_tip = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    image_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercise", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "muscle_group",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_muscle_group", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "single_workout",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    day = table.Column<int>(type: "integer", nullable: false),
                    is_rest_day = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_single_workout", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    gender = table.Column<int>(type: "integer", nullable: false),
                    age = table.Column<int>(type: "integer", nullable: false),
                    height = table.Column<double>(type: "double precision", nullable: false),
                    weight = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "exercise_perform_info",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    exercise_id = table.Column<int>(type: "integer", nullable: false),
                    sets = table.Column<int>(type: "integer", nullable: false),
                    reps = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercise_perform_info", x => x.id);
                    table.ForeignKey(
                        name: "FK_exercise_perform_info_exercise_exercise_id",
                        column: x => x.exercise_id,
                        principalTable: "exercise",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "exercises_muscle_group",
                columns: table => new
                {
                    exercise_id = table.Column<int>(type: "integer", nullable: false),
                    muscle_group_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercises_muscle_group", x => new { x.exercise_id, x.muscle_group_id });
                    table.ForeignKey(
                        name: "FK_exercises_muscle_group_exercise_exercise_id",
                        column: x => x.exercise_id,
                        principalTable: "exercise",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_exercises_muscle_group_muscle_group_muscle_group_id",
                        column: x => x.muscle_group_id,
                        principalTable: "muscle_group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "workout_plan",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    user_id = table.Column<string>(type: "character varying(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workout_plan", x => x.id);
                    table.ForeignKey(
                        name: "FK_workout_plan_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "exercise_perform_info_single_workout",
                columns: table => new
                {
                    exercise_perform_info_id = table.Column<int>(type: "integer", nullable: false),
                    single_workout_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercise_perform_info_single_workout", x => new { x.exercise_perform_info_id, x.single_workout_id });
                    table.ForeignKey(
                        name: "FK_exercise_perform_info_single_workout_exercise_perform_info_~",
                        column: x => x.exercise_perform_info_id,
                        principalTable: "exercise_perform_info",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_exercise_perform_info_single_workout_single_workout_single_~",
                        column: x => x.single_workout_id,
                        principalTable: "single_workout",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "single_workout_workout_plan",
                columns: table => new
                {
                    single_workout_id = table.Column<int>(type: "integer", nullable: false),
                    workout_plan_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_single_workout_workout_plan", x => new { x.single_workout_id, x.workout_plan_id });
                    table.ForeignKey(
                        name: "FK_single_workout_workout_plan_single_workout_single_workout_id",
                        column: x => x.single_workout_id,
                        principalTable: "single_workout",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_single_workout_workout_plan_workout_plan_workout_plan_id",
                        column: x => x.workout_plan_id,
                        principalTable: "workout_plan",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_exercise_perform_info_exercise_id",
                table: "exercise_perform_info",
                column: "exercise_id");

            migrationBuilder.CreateIndex(
                name: "IX_exercise_perform_info_single_workout_single_workout_id",
                table: "exercise_perform_info_single_workout",
                column: "single_workout_id");

            migrationBuilder.CreateIndex(
                name: "IX_exercises_muscle_group_muscle_group_id",
                table: "exercises_muscle_group",
                column: "muscle_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_single_workout_workout_plan_workout_plan_id",
                table: "single_workout_workout_plan",
                column: "workout_plan_id");

            migrationBuilder.CreateIndex(
                name: "IX_workout_plan_user_id",
                table: "workout_plan",
                column: "user_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "exercise_perform_info_single_workout");

            migrationBuilder.DropTable(
                name: "exercises_muscle_group");

            migrationBuilder.DropTable(
                name: "single_workout_workout_plan");

            migrationBuilder.DropTable(
                name: "exercise_perform_info");

            migrationBuilder.DropTable(
                name: "muscle_group");

            migrationBuilder.DropTable(
                name: "single_workout");

            migrationBuilder.DropTable(
                name: "workout_plan");

            migrationBuilder.DropTable(
                name: "exercise");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
