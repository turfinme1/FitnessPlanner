using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessPlanner.Data.Models
{
    [Table("exercise_perform_info")]
    public class ExercisePerformInfo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("exercise_id")]
        public int ExerciseId { get; set; }

        [ForeignKey(nameof(ExerciseId))]
        public Exercise Exercise { get; set; } = null!;

        [Required]
        [Column("sets")]
        public int Sets { get; set; }

        [Required]
        [Column("reps")]
        public int Reps { get; set; }

        public IEnumerable<ExercisePerformInfoSingleWorkout> ExercisePerformInfoSingleWorkouts { get; set; } = [];
    }
}
