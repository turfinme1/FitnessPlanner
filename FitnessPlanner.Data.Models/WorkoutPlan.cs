using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.WorkoutPlanConstants;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents a workout plan entity.
    /// </summary>
    [Table("workout_plan")]
    public class WorkoutPlan
    {
        /// <summary>
        /// The unique identifier for the workout plan.
        /// </summary>
        [Key]
        [Column("id")]
        [Comment("The unique identifier for the workout plan.")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the workout plan.
        /// </summary>
        [Required]
        [Column("name")]
        [MaxLength(NameMaxLength)]
        [Comment("The name of the workout plan.")]
        public required string Name { get; set; }

        /// <summary>
        /// The ID of the user associated with the workout plan.
        /// </summary>
        [Column("user_id")]
        [MaxLength(UserIdMaxLength)]
        [Comment("The ID of the user associated with the workout plan.")]
        public string? UserId { get; set; }

        /// <summary>
        /// The user associated with the workout plan.
        /// </summary>
        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }

        /// <summary>
        /// The ID of the skill level associated with the workout plan.
        /// </summary>
        [Required]
        [Column("skill_level_id")]
        [Comment("The ID of the skill level associated with the workout plan.")]
        public int SkillLevelId { get; set; }

        /// <summary>
        /// The skill level associated with the workout plan.
        /// </summary>
        [ForeignKey(nameof(SkillLevelId))]
        public SkillLevel SkillLevel { get; set; } = null!;

        /// <summary>
        /// The ID of the goal associated with the workout plan.
        /// </summary>
        [Required]
        [Column("goal_id")]
        [Comment("The ID of the goal associated with the workout plan.")]
        public int GoalId { get; set; }

        /// <summary>
        /// The goal associated with the workout plan.
        /// </summary>
        [ForeignKey(nameof(GoalId))]
        public Goal Goal { get; set; } = null!;

        /// <summary>
        /// A collection representing many-to-many relationship between <see cref="SingleWorkout"/> and <see cref="WorkoutPlan"/>.
        /// </summary>
        public IEnumerable<SingleWorkoutWorkoutPlan> SingleWorkoutWorkoutPlans { get; set; } = new List<SingleWorkoutWorkoutPlan>();

        /// <summary>
        /// A collection representing many-to-many relationship between <see cref="WorkoutPlan"/> and <see cref="BodyMassIndexMeasure"/>.
        /// </summary>
        public IEnumerable<WorkoutPlanBodyMassIndexMeasure> WorkoutPlanBodyMassIndexMeasures { get; set; } = new List<WorkoutPlanBodyMassIndexMeasure>();
    }
}
