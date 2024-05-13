using FitnessPlanner.Services.Models.SingleWorkout;

namespace FitnessPlanner.Services.Models.WorkoutPlan
{
    public class WorkoutPlanDto
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Goal { get; set; }

        public required string SkillLevel { get; set; }

        public required IEnumerable<SingleWorkoutDto> Workouts { get; set; }
    }
}
