using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessPlanner.Data.Models
{   
    /// <summary>
    /// Represents the many-to-many relationship between a <see cref="User"/> and a <see cref="WorkoutPlan"/>.
    /// </summary>
    [Table("user_workout_plan")]
    [PrimaryKey(nameof(UserId), nameof(WorkoutPlanId))]
    public class UserWorkoutPlan
    {
        /// <summary>
        /// The ID of the associated user.
        /// </summary>
        [Column("user_id")]
        [Comment("The ID of the associated user.")]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// The user associated with this relationship.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

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
