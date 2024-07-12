using FitnessPlanner.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.UserConstants;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents a user entity extending <see cref="IdentityUser"/>.
    /// </summary>
    [Table("user")]
    public class User : IdentityUser
    {
        /// <summary>
        /// The name of the user.
        /// </summary>
        [Required]
        [Column("name")]
        [MaxLength(NameMaxLength)]
        [Comment("The name of the user.")]
        public required string Name { get; set; }

        /// <summary>
        /// The gender of the user.
        /// </summary>
        [Required]
        [Column("gender")]
        [Comment("The gender of the user.")]
        public Genders Gender { get; set; }

        /// <summary>
        /// The age of the user.
        /// </summary>
        [Required]
        [Column("age")]
        [Comment("The age of the user.")]
        public int Age { get; set; }

        /// <summary>
        /// The height of the user.
        /// </summary>
        [Required]
        [Column("height")]
        [Comment("The height of the user.")]
        public double Height { get; set; }

        /// <summary>
        /// The weight of the user.
        /// </summary>
        [Required]
        [Column("weight")]
        [Comment("The weight of the user.")]
        public double Weight { get; set; }

        /// <summary>
        /// The ID of the skill level associated with the user.
        /// </summary>
        [Required]
        [Column("skill_level_id")]
        [Comment("The ID of the skill level associated with the user.")]
        public int SkillLevelId { get; set; }

        /// <summary>
        /// The skill level associated with the user.
        /// </summary>
        [ForeignKey(nameof(SkillLevelId))]
        public SkillLevel SkillLevel { get; set; } = null!;

        /// <summary>
        /// The ID of the goal associated with the user.
        /// </summary>
        [Required]
        [Column("goal_id")]
        [Comment("The ID of the goal associated with the user.")]
        public int GoalId { get; set; }

        /// <summary>
        /// The goal associated with the user.
        /// </summary>
        [ForeignKey(nameof(GoalId))]
        public Goal Goal { get; set; } = null!;

        /// <summary>
        /// The ID of the body mass index measure associated with the user.
        /// </summary>
        [Required]
        [Column("body_mass_index_measure_id")]
        [Comment("The ID of the body mass index measure associated with the user.")]
        public int BodyMassIndexMeasureId { get; set; }

        /// <summary>
        /// The body mass index measure associated with the user.
        /// </summary>
        [ForeignKey(nameof(BodyMassIndexMeasureId))]
        public BodyMassIndexMeasure BodyMassIndexMeasure { get; set; } = null!;

        /// <summary>
        /// The workout plans associated with the user.
        /// </summary>
        public IEnumerable<WorkoutPlan> WorkoutPlans { get; set; } = new List<WorkoutPlan>();
    }
}
