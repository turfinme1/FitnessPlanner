using FitnessPlanner.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.UserConstants;

namespace FitnessPlanner.Data.Models
{
    [Table("user")]
    public class User : IdentityUser
    {
        [Required]
        [Column("name")]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; }

        [Required]
        [Column("gender")]
        public Genders Gender { get; set; }

        [Required]
        [Column("age")]
        public int Age { get; set; }

        [Required]
        [Column("height")]
        public double Height { get; set; }

        [Required]
        [Column("weight")]
        public double Weight { get; set; }

        [Required]
        [Column("skill_level_id")]
        public int SkillLevelId { get; set; }

        [ForeignKey(nameof(SkillLevelId))]
        public SkillLevel SkillLevel { get; set; } = null!;

        [Required]
        [Column("goal_id")]
        public int GoalId { get; set; }

        [ForeignKey(nameof(GoalId))]
        public Goal Goal { get; set; } = null!;

        [Required]
        [Column("body_mass_index_measure_id")]
        public int BodyMassIndexMeasureId { get; set; }

        [ForeignKey(nameof(BodyMassIndexMeasureId))]
        public BodyMassIndexMeasure BodyMassIndexMeasure { get; set; } = null!;

        public WorkoutPlan? WorkoutPlan { get; set; }
    }
}
