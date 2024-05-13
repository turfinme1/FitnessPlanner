using FitnessPlanner.Data.Models.Enums;
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
        public DaysOfWeek Day { get; set; }

        public IEnumerable<ExercisePerformInfoSingleWorkout> ExercisePerformInfoSingleWorkouts { get; set; } = new List<ExercisePerformInfoSingleWorkout>();

        public IEnumerable<SingleWorkoutWorkoutPlan> SingleWorkoutWorkoutPlans { get; set; } = new List<SingleWorkoutWorkoutPlan>();
    }
}
