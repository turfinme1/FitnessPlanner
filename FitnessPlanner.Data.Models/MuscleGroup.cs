using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.MuscleGroupConstants;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents a muscle group entity.
    /// </summary>
    [Table("muscle_group")]
    public class MuscleGroup
    {
        /// <summary>
        /// The unique identifier for the muscle group.
        /// </summary>
        [Key]
        [Column("id")]
        [Comment("The unique identifier for the muscle group.")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the muscle group.
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Column("name")]
        [Comment("The name of the muscle group.")]
        public required string Name { get; set; }

        /// <summary>
        /// A collection representing many-to-many relationship between <see cref="Exercise"/> and <see cref="MuscleGroup"/>.
        /// </summary>
        public IEnumerable<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; } = new List<ExerciseMuscleGroup>();
    }
}
