namespace FitnessPlanner.Services.Models.WorkoutPlan
{
    public class WorkoutPlanSuggestionDto
    {
        public WorkoutPlanDisplayDto WorkoutPlan { get; set; } = null!;

        public decimal SimilarityScore { get; set; }
    }
}
