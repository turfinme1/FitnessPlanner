using FitnessPlanner.Services.Models.ExercisePerformInfo;

namespace FitnessPlanner.Services.Models.SingleWorkout
{
    public class SingleWorkoutDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Day { get; set; }

        public required IEnumerable<ExercisePerformInfoDto> Exercises { get; set; }
    }
}
