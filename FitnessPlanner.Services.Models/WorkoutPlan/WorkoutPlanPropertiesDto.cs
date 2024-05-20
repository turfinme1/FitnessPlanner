using FitnessPlanner.Services.Models.SingleWorkout;

namespace FitnessPlanner.Services.Models.WorkoutPlan
{
    public class WorkoutPlanPropertiesDto
    {
        public int Id { get; set; }

        public required string Goal { get; set; }

        public required string SkillLevel { get; set; }

        public required IEnumerable<string> BodyMassIndexMeasures { get; set; }
    }
}
