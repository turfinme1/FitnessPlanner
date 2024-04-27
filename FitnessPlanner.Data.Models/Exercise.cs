using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.ExerciseConstants;

namespace FitnessPlanner.Data.Models
{
    [Table("exercise")]
    public class Exercise
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Column("name")]
        public required string Name { get; set; }

        [Required]
        [MaxLength(ExplanationMaxLength)]
        [Column("explanation")]
        public required string Explanation { get; set; }

        [Required]
        [MaxLength(PerformTipMaxLength)]
        [Column("perform_tip")]
        public required string PerformTip { get; set; }

        [Required]
        [MaxLength(ImageNameMaxLength)]
        [Column("image_name")]
        public required string ImageName { get; set; }

        public IEnumerable<ExercisePerformInfo> PerformInfos { get; set; } = [];
    }
}
