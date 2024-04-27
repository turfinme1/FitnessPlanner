using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessPlanner.Data.Models
{
    [Table("exercise_perform_info_single_workout")]
    [PrimaryKey(nameof(ExercisePerformInfoId), nameof(SingleWorkoutId))]
    public class ExercisePerformInfoSingleWorkout
    {
        [Column("exercise_perform_info_id")]
        public int ExercisePerformInfoId { get; set; }

        [ForeignKey(nameof(ExercisePerformInfoId))]
        public ExercisePerformInfo ExercisePerformInfo { get; set; } = null!;

        [Column("single_workout_id")]
        public int SingleWorkoutId { get; set; }

        [ForeignKey(nameof(SingleWorkoutId))]
        public SingleWorkout SingleWorkout { get; set; } = null!;
    }
}
