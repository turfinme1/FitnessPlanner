using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.SkillLevelConstants;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents a skill level entity.
    /// </summary>
    [Table("skill_level")]
    public class SkillLevel
    {
        /// <summary>
        /// The unique identifier for the skill level.
        /// </summary>
        [Key]
        [Column("id")]
        [Comment("The unique identifier for the skill level.")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the skill level.
        /// </summary>
        [Required]
        [MaxLength(SkillNameMaxLength)]
        [Column("name")]
        [Comment("The name of the skill level.")]
        public required string Name { get; set; }

        /// <summary>
        /// A collection of workout plans associated with this skill level.
        /// </summary>
        public IEnumerable<WorkoutPlan> WorkoutPlans { get; set; } = new List<WorkoutPlan>();

        /// <summary>
        /// A collection of users associated with this skill level.
        /// </summary>
        public IEnumerable<User> Users { get; set; } = new List<User>();
    }
}
