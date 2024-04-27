using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.WorkoutPlanConstants;

namespace FitnessPlanner.Data.Models
{
    [Table("workout_plan")]
    public class WorkoutPlan
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; }

        [Column("user_id")]
        [MaxLength(UserIdMaxLength)]
        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }

        public IEnumerable<SingleWorkoutWorkoutPlan> SingleWorkoutWorkoutPlans { get; set; } = [];
    }
}
