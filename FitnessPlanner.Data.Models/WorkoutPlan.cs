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

        [Column("skill_level_id")]
        public int SkillLevelId { get; set; }

        [ForeignKey(nameof(SkillLevelId))]
        public SkillLevel SkillLevel { get; set; } = null!;

        [Column("goal_id")]
        public int GoalId { get; set; }
            
        [ForeignKey(nameof(GoalId))]
        public Goal Goal { get; set; } = null!;

        public IEnumerable<SingleWorkoutWorkoutPlan> SingleWorkoutWorkoutPlans { get; set; } = [];

        public IEnumerable<WorkoutPlanBodyMassIndexMeasure> WorkoutPlanBodyMassIndexMeasures { get; set; } = [];
    }
}
