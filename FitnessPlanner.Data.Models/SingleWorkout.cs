using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.SingleWorkoutConstants;

namespace FitnessPlanner.Data.Models
{
    [Table("single_workout")]
    public class SingleWorkout
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; }

        [Required]
        [Column("day")]
        public DayOfWeek Day { get; set; }

        [Required]
        [Column("is_rest_day")]
        public bool IsRestDay { get; set; }

        public IEnumerable<ExercisePerformInfoSingleWorkout> ExercisePerformInfoSingleWorkouts { get; set; } = [];

        public IEnumerable<SingleWorkoutWorkoutPlan> SingleWorkoutWorkoutPlans { get; set; } = [];
    }
}
