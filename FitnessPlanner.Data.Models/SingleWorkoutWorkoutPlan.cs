using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents the many-to-many relationship between a <see cref="SingleWorkout"/> and a <see cref="WorkoutPlan"/>.
    /// </summary>
    [Table("single_workout_workout_plan")]
    [PrimaryKey(nameof(SingleWorkoutId), nameof(WorkoutPlanId))]
    public class SingleWorkoutWorkoutPlan
    {
        /// <summary>
        /// The ID of the associated single workout.
        /// </summary>
        [Column("single_workout_id")]
        [Comment("The ID of the associated single workout.")]
        public int SingleWorkoutId { get; set; }

        /// <summary>
        /// The single workout associated with this relationship.
        /// </summary>
        [ForeignKey(nameof(SingleWorkoutId))]
        public SingleWorkout SingleWorkout { get; set; } = null!;

        /// <summary>
        /// The ID of the associated workout plan.
        /// </summary>
        [Column("workout_plan_id")]
        [Comment("The ID of the associated workout plan.")]
        public int WorkoutPlanId { get; set; }

        /// <summary>
        /// The workout plan associated with this relationship.
        /// </summary>
        [ForeignKey(nameof(WorkoutPlanId))]
        public WorkoutPlan WorkoutPlan { get; set; } = null!;
    }
}
