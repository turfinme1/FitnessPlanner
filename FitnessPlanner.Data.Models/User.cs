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

        public WorkoutPlan? WorkoutPlan { get; set; }
    }
}
