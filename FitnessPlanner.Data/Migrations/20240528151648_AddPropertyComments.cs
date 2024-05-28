using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FitnessPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertyComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "body_mass_index_measure_id",
                table: "workout_plan_body_mass_index_measure",
                type: "integer",
                nullable: false,
                comment: "The ID of the associated body mass index measure.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "workout_plan_id",
                table: "workout_plan_body_mass_index_measure",
                type: "integer",
                nullable: false,
                comment: "The ID of the associated workout plan.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "workout_plan",
                type: "character varying(450)",
                maxLength: 450,
                nullable: true,
                comment: "The ID of the user associated with the workout plan.",
                oldClrType: typeof(string),
                oldType: "character varying(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "skill_level_id",
                table: "workout_plan",
                type: "integer",
                nullable: false,
                comment: "The ID of the skill level associated with the workout plan.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "workout_plan",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                comment: "The name of the workout plan.",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "goal_id",
                table: "workout_plan",
                type: "integer",
                nullable: false,
                comment: "The ID of the goal associated with the workout plan.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "workout_plan",
                type: "integer",
                nullable: false,
                comment: "The unique identifier for the workout plan.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<double>(
                name: "weight",
                table: "user",
                type: "double precision",
                nullable: false,
                comment: "The weight of the user.",
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<int>(
                name: "skill_level_id",
                table: "user",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                comment: "The ID of the skill level associated with the user.",
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "user",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                comment: "The name of the user.",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<double>(
                name: "height",
                table: "user",
                type: "double precision",
                nullable: false,
                comment: "The height of the user.",
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<int>(
                name: "goal_id",
                table: "user",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                comment: "The ID of the goal associated with the user.",
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "gender",
                table: "user",
                type: "integer",
                nullable: false,
                comment: "The gender of the user.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "body_mass_index_measure_id",
                table: "user",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                comment: "The ID of the body mass index measure associated with the user.",
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "age",
                table: "user",
                type: "integer",
                nullable: false,
                comment: "The age of the user.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "skill_level",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "The name of the skill level.",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "skill_level",
                type: "integer",
                nullable: false,
                comment: "The unique identifier for the skill level.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "workout_plan_id",
                table: "single_workout_workout_plan",
                type: "integer",
                nullable: false,
                comment: "The ID of the associated workout plan.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "single_workout_id",
                table: "single_workout_workout_plan",
                type: "integer",
                nullable: false,
                comment: "The ID of the associated single workout.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "single_workout",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "The name of the single workout.",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "day",
                table: "single_workout",
                type: "integer",
                nullable: false,
                comment: "The day of the week on which the single workout is scheduled.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "single_workout",
                type: "integer",
                nullable: false,
                comment: "The unique identifier for the single workout.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "muscle_group",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "The name of the muscle group.",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "muscle_group",
                type: "integer",
                nullable: false,
                comment: "The unique identifier for the muscle group.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "goal",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "The name of the goal.",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "goal",
                type: "integer",
                nullable: false,
                comment: "The unique identifier for the goal.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "muscle_group_id",
                table: "exercises_muscle_group",
                type: "integer",
                nullable: false,
                comment: "The ID of the associated muscle group.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "exercise_id",
                table: "exercises_muscle_group",
                type: "integer",
                nullable: false,
                comment: "The ID of the associated exercise.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "single_workout_id",
                table: "exercise_perform_info_single_workout",
                type: "integer",
                nullable: false,
                comment: "The ID of the associated single workout.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "exercise_perform_info_id",
                table: "exercise_perform_info_single_workout",
                type: "integer",
                nullable: false,
                comment: "The ID of the associated exercise performance information.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "sets",
                table: "exercise_perform_info",
                type: "integer",
                nullable: false,
                comment: "The number of sets for the exercise.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "reps",
                table: "exercise_perform_info",
                type: "integer",
                nullable: false,
                comment: "The number of repetitions for each set of the exercise.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "exercise_id",
                table: "exercise_perform_info",
                type: "integer",
                nullable: false,
                comment: "The ID of the associated exercise.",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "exercise_perform_info",
                type: "integer",
                nullable: false,
                comment: "The unique identifier for the exercise performance information.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "perform_tip",
                table: "exercise",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: false,
                comment: "Tips for performing the exercise.",
                oldClrType: typeof(string),
                oldType: "character varying(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "exercise",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "The name of the exercise.",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "image_name",
                table: "exercise",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                comment: "The name of the image associated with the exercise.",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "explanation",
                table: "exercise",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: false,
                comment: "The explanation of the exercise.",
                oldClrType: typeof(string),
                oldType: "character varying(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "exercise",
                type: "integer",
                nullable: false,
                comment: "The unique identifier for the exercise.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "body_mass_index_measure",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                comment: "The type of the body mass index measure.",
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "body_mass_index_measure",
                type: "integer",
                nullable: false,
                comment: "The unique identifier for the body mass index measure.",
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_user_body_mass_index_measure_body_mass_index_measure_id",
                table: "user",
                column: "body_mass_index_measure_id",
                principalTable: "body_mass_index_measure",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_goal_goal_id",
                table: "user",
                column: "goal_id",
                principalTable: "goal",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_skill_level_skill_level_id",
                table: "user",
                column: "skill_level_id",
                principalTable: "skill_level",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.AlterColumn<int>(
                name: "body_mass_index_measure_id",
                table: "workout_plan_body_mass_index_measure",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the associated body mass index measure.");

            migrationBuilder.AlterColumn<int>(
                name: "workout_plan_id",
                table: "workout_plan_body_mass_index_measure",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the associated workout plan.");

            migrationBuilder.AlterColumn<string>(
                name: "user_id",
                table: "workout_plan",
                type: "character varying(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(450)",
                oldMaxLength: 450,
                oldNullable: true,
                oldComment: "The ID of the user associated with the workout plan.");

            migrationBuilder.AlterColumn<int>(
                name: "skill_level_id",
                table: "workout_plan",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the skill level associated with the workout plan.");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "workout_plan",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldComment: "The name of the workout plan.");

            migrationBuilder.AlterColumn<int>(
                name: "goal_id",
                table: "workout_plan",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the goal associated with the workout plan.");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "workout_plan",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The unique identifier for the workout plan.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<double>(
                name: "weight",
                table: "user",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldComment: "The weight of the user.");

            migrationBuilder.AlterColumn<int>(
                name: "skill_level_id",
                table: "user",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the skill level associated with the user.");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "user",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldComment: "The name of the user.");

            migrationBuilder.AlterColumn<double>(
                name: "height",
                table: "user",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldComment: "The height of the user.");

            migrationBuilder.AlterColumn<int>(
                name: "goal_id",
                table: "user",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the goal associated with the user.");

            migrationBuilder.AlterColumn<int>(
                name: "gender",
                table: "user",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The gender of the user.");

            migrationBuilder.AlterColumn<int>(
                name: "body_mass_index_measure_id",
                table: "user",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the body mass index measure associated with the user.");

            migrationBuilder.AlterColumn<int>(
                name: "age",
                table: "user",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The age of the user.");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "skill_level",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "The name of the skill level.");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "skill_level",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The unique identifier for the skill level.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "workout_plan_id",
                table: "single_workout_workout_plan",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the associated workout plan.");

            migrationBuilder.AlterColumn<int>(
                name: "single_workout_id",
                table: "single_workout_workout_plan",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the associated single workout.");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "single_workout",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "The name of the single workout.");

            migrationBuilder.AlterColumn<int>(
                name: "day",
                table: "single_workout",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The day of the week on which the single workout is scheduled.");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "single_workout",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The unique identifier for the single workout.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "muscle_group",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "The name of the muscle group.");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "muscle_group",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The unique identifier for the muscle group.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "goal",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "The name of the goal.");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "goal",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The unique identifier for the goal.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "muscle_group_id",
                table: "exercises_muscle_group",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the associated muscle group.");

            migrationBuilder.AlterColumn<int>(
                name: "exercise_id",
                table: "exercises_muscle_group",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the associated exercise.");

            migrationBuilder.AlterColumn<int>(
                name: "single_workout_id",
                table: "exercise_perform_info_single_workout",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the associated single workout.");

            migrationBuilder.AlterColumn<int>(
                name: "exercise_perform_info_id",
                table: "exercise_perform_info_single_workout",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the associated exercise performance information.");

            migrationBuilder.AlterColumn<int>(
                name: "sets",
                table: "exercise_perform_info",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The number of sets for the exercise.");

            migrationBuilder.AlterColumn<int>(
                name: "reps",
                table: "exercise_perform_info",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The number of repetitions for each set of the exercise.");

            migrationBuilder.AlterColumn<int>(
                name: "exercise_id",
                table: "exercise_perform_info",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The ID of the associated exercise.");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "exercise_perform_info",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The unique identifier for the exercise performance information.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "perform_tip",
                table: "exercise",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(2000)",
                oldMaxLength: 2000,
                oldComment: "Tips for performing the exercise.");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "exercise",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "The name of the exercise.");

            migrationBuilder.AlterColumn<string>(
                name: "image_name",
                table: "exercise",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldComment: "The name of the image associated with the exercise.");

            migrationBuilder.AlterColumn<string>(
                name: "explanation",
                table: "exercise",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(2000)",
                oldMaxLength: 2000,
                oldComment: "The explanation of the exercise.");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "exercise",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The unique identifier for the exercise.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "type",
                table: "body_mass_index_measure",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldComment: "The type of the body mass index measure.");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "body_mass_index_measure",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "The unique identifier for the body mass index measure.")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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
    }
}
