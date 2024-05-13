namespace FitnessPlanner.Services.Models.ExercisePerformInfo
{
    public class ExercisePerformInfoDto
    {
        public int Id { get; set; }

        public required string ExerciseName { get; set; }

        public int Reps { get; set; }

        public int Sets { get; set; }

    }
}
