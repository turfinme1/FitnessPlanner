using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.SkillLevelConstants;

namespace FitnessPlanner.Data.Models
{
    [Table("skill_level")]
    public class SkillLevel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Column("name")]
        public required string Name { get; set; }

        public IEnumerable<WorkoutPlan> WorkoutPlans { get; set; } = [];

        public IEnumerable<User> Users { get; set; } = [];
    }
}
