using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FitnessPlanner.Data.Models
{
    [PrimaryKey(nameof(ExerciseId), nameof(MuscleGroupId))]
    [Table("exercises_muscle_group")]
    public class ExerciseMuscleGroup
    {
        [Column("exercise_id")]
        public int ExerciseId { get; set; }

        [ForeignKey(nameof(ExerciseId))]
        public Exercise Exercise { get; set; } = null!;

        [Column("muscle_group_id")]
        public int MuscleGroupId { get; set; }

        [ForeignKey(nameof(MuscleGroupId))]
        public MuscleGroup MuscleGroup { get; set; } = null!;
    }
}
