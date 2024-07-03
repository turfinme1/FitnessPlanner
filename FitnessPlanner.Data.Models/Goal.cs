using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.GoalConstants;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents a goal entity.
    /// </summary>
    [Table("goal")]
    public class Goal
    {
        /// <summary>
        /// The unique identifier for the goal.
        /// </summary>
        [Key]
        [Column("id")]
        [Comment("The unique identifier for the goal.")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the goal.
        /// </summary>
        [Required]
        [MaxLength(GoalNameMaxLength)]
        [Column("name")]
        [Comment("The name of the goal.")]
        public required string Name { get; set; }

        /// <summary>
        /// A collection of workout plans associated with this goal.
        /// </summary>
        public IEnumerable<WorkoutPlan> WorkoutPlans { get; set; } = new List<WorkoutPlan>();

        /// <summary>
        /// A collection of users associated with this goal.
        /// </summary>
        public IEnumerable<User> Users { get; set; } = new List<User>();
    }
}
