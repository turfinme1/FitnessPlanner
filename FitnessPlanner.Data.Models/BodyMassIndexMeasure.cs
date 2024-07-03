using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.BodyMassIndexMeasureConstants;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents a body mass index measure entity.
    /// </summary>
    [Table("body_mass_index_measure")]
    public class BodyMassIndexMeasure
    {
        /// <summary>
        /// The unique identifier for the body mass index measure.
        /// </summary>
        [Key]
        [Column("id")]
        [Comment("The unique identifier for the body mass index measure.")]
        public int Id { get; set; }

        /// <summary>
        /// The type of the body mass index measure.
        /// </summary>
        [Required]
        [MaxLength(TypeMaxLength)]
        [Column("type")]
        [Comment("The type of the body mass index measure.")]
        public required string Type { get; set; }

        /// <summary>
        /// A collection of users associated with this body mass index measure.
        /// </summary>
        public IEnumerable<User> Users { get; set; } = new List<User>();

        /// <summary>
        /// A collection representing many-to-many relationship between <see cref="WorkoutPlan"/> and <see cref="BodyMassIndexMeasure"/>.
        /// </summary>
        public IEnumerable<WorkoutPlanBodyMassIndexMeasure> WorkoutPlanBodyMassIndexMeasures { get; set; } = new List<WorkoutPlanBodyMassIndexMeasure>();
    }
}
