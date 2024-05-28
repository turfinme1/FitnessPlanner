using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.ExerciseConstants;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents an exercise entity.
    /// </summary>
    [Table("exercise")]
    public class Exercise
    {
        /// <summary>
        /// The unique identifier for the exercise.
        /// </summary>
        [Key]
        [Column("id")]
        [Comment("The unique identifier for the exercise.")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the exercise.
        /// </summary>
        [Required]
        [MaxLength(NameMaxLength)]
        [Column("name")]
        [Comment("The name of the exercise.")]
        public required string Name { get; set; }

        /// <summary>
        /// The explanation of the exercise.
        /// </summary>
        [Required]
        [MaxLength(ExplanationMaxLength)]
        [Column("explanation")]
        [Comment("The explanation of the exercise.")]
        public required string Explanation { get; set; }

        /// <summary>
        /// Tips for performing the exercise.
        /// </summary>
        [Required]
        [MaxLength(PerformTipMaxLength)]
        [Column("perform_tip")]
        [Comment("Tips for performing the exercise.")]
        public required string PerformTip { get; set; }

        /// <summary>
        /// The name of the image associated with the exercise.
        /// </summary>
        [Required]
        [MaxLength(ImageNameMaxLength)]
        [Column("image_name")]
        [Comment("The name of the image associated with the exercise.")]
        public required string ImageName { get; set; }

        /// <summary>
        /// A collection of exercise perform info entities associated with this exercise.
        /// </summary>
        public IEnumerable<ExercisePerformInfo> ExercisePerformInfos { get; set; } = new List<ExercisePerformInfo>();

        /// <summary>
        /// A collection of exercise muscle group entities associated with this exercise.
        /// </summary>
        public IEnumerable<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; } = new List<ExerciseMuscleGroup>();
    }
}
