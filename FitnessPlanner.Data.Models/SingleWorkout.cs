using FitnessPlanner.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.SingleWorkoutConstants;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents a single workout entity.
    /// </summary>
    [Table("single_workout")]
    public class SingleWorkout
    {
        /// <summary>
        /// The unique identifier for the single workout.
        /// </summary>
        [Key]
        [Column("id")]
        [Comment("The unique identifier for the single workout.")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the single workout.
        /// </summary>
        [Required]
        [Column("name")]
        [MaxLength(NameMaxLength)]
        [Comment("The name of the single workout.")]
        public required string Name { get; set; }

        /// <summary>
        /// The day of the week on which the single workout is scheduled.
        /// </summary>
        [Required]
        [Column("day")]
        [Comment("The day of the week on which the single workout is scheduled.")]
        public DaysOfWeek Day { get; set; }

        /// <summary>
        /// A collection representing many-to-many relationship between <see cref="ExercisePerformInfo"/> and <see cref="SingleWorkout"/>.
        /// </summary>
        public IEnumerable<ExercisePerformInfoSingleWorkout> ExercisePerformInfoSingleWorkouts { get; set; } = new List<ExercisePerformInfoSingleWorkout>();

        /// <summary>
        /// A collection representing many-to-many relationship between <see cref="SingleWorkout"/> and <see cref="WorkoutPlan"/>.
        /// </summary>
        public IEnumerable<SingleWorkoutWorkoutPlan> SingleWorkoutWorkoutPlans { get; set; } = new List<SingleWorkoutWorkoutPlan>();
    }
}
