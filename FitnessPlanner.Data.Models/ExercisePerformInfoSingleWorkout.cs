using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents the many-to-many relationship between <see cref="Models.ExercisePerformInfo"/> and <see cref="Models.SingleWorkout"/>.
    /// </summary>
    [Table("exercise_perform_info_single_workout")]
    [PrimaryKey(nameof(ExercisePerformInfoId), nameof(SingleWorkoutId))]
    public class ExercisePerformInfoSingleWorkout
    {
        /// <summary>
        /// The ID of the associated exercise performance information.
        /// </summary>
        [Column("exercise_perform_info_id")]
        [Comment("The ID of the associated exercise performance information.")]
        public int ExercisePerformInfoId { get; set; }

        /// <summary>
        /// The exercise performance information associated with this relationship.
        /// </summary>
        [ForeignKey(nameof(ExercisePerformInfoId))]
        public ExercisePerformInfo ExercisePerformInfo { get; set; } = null!;

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
    }

}
