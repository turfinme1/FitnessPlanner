using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.GoalConstants;

namespace FitnessPlanner.Data.Models
{
    [Table("goal")]
    public class Goal
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Column("name")]
        public required string Name { get; set; }

        public IEnumerable<WorkoutPlan> WorkoutPlans { get; set; } = new List<WorkoutPlan>();

        public IEnumerable<User> Users { get; set; } = new List<User>();
    }
}
