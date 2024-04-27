using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessPlanner.Data.Models
{
    [Table("single_workout_workout_plan")]
    [PrimaryKey(nameof(SingleWorkoutId), nameof(WorkoutPlanId))]
    public class SingleWorkoutWorkoutPlan
    {
        [Column("single_workout_id")]
        public int SingleWorkoutId { get; set; }

        [ForeignKey(nameof(SingleWorkoutId))]
        public SingleWorkout SingleWorkout { get; set; } = null!;

        [Column("workout_plan_id")]
        public int WorkoutPlanId { get; set; }

        [ForeignKey(nameof(WorkoutPlanId))]
        public WorkoutPlan WorkoutPlan { get; set; } = null!;
    }
}
