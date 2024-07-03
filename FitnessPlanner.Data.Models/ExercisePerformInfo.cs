using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents the performance information of an <see cref="Models.Exercise"/>.
    /// </summary>
    [Table("exercise_perform_info")]
    public class ExercisePerformInfo
    {
        /// <summary>
        /// The unique identifier for the exercise performance information.
        /// </summary>
        [Key]
        [Column("id")]
        [Comment("The unique identifier for the exercise performance information.")]
        public int Id { get; set; }

        /// <summary>
        /// The ID of the associated exercise.
        /// </summary>
        [Required]
        [Column("exercise_id")]
        [Comment("The ID of the associated exercise.")]
        public int ExerciseId { get; set; }

        /// <summary>
        /// The exercise associated with this performance information.
        /// </summary>
        [ForeignKey(nameof(ExerciseId))]
        public Exercise Exercise { get; set; } = null!;

        /// <summary>
        /// The number of sets for the exercise.
        /// </summary>
        [Required]
        [Column("sets")]
        [Comment("The number of sets for the exercise.")]
        public int Sets { get; set; }

        /// <summary>
        /// The number of repetitions for each set of the exercise.
        /// </summary>
        [Required]
        [Column("reps")]
        [Comment("The number of repetitions for each set of the exercise.")]
        public int Reps { get; set; }

        /// <summary>
        /// A collection representing many-to-many relationship between <see cref="ExercisePerformInfo"/> and <see cref="SingleWorkout"/>.
        /// </summary>
        public IEnumerable<ExercisePerformInfoSingleWorkout> ExercisePerformInfoSingleWorkouts { get; set; } = new List<ExercisePerformInfoSingleWorkout>();
    }
}
