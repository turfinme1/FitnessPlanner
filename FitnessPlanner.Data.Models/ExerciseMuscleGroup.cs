using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents the many-to-many relationship between <see cref="Models.Exercise"/> and <see cref="Models.MuscleGroup"/>.
    /// </summary>
    [Table("exercises_muscle_group")]
    [PrimaryKey(nameof(ExerciseId), nameof(MuscleGroupId))]
    public class ExerciseMuscleGroup
    {
        /// <summary>
        /// The ID of the associated exercise.
        /// </summary>
        [Column("exercise_id")]
        [Comment("The ID of the associated exercise.")]
        public int ExerciseId { get; set; }

        /// <summary>
        /// The exercise associated with this relationship.
        /// </summary>
        [ForeignKey(nameof(ExerciseId))]
        public Exercise Exercise { get; set; } = null!;

        /// <summary>
        /// The ID of the associated muscle group.
        /// </summary>
        [Column("muscle_group_id")]
        [Comment("The ID of the associated muscle group.")]
        public int MuscleGroupId { get; set; }

        /// <summary>
        /// The muscle group associated with this relationship.
        /// </summary>
        [ForeignKey(nameof(MuscleGroupId))]
        public MuscleGroup MuscleGroup { get; set; } = null!;
    }
}
