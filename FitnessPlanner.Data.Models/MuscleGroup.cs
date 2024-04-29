using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.MuscleGroupConstants;

namespace FitnessPlanner.Data.Models
{
    [Table("muscle_group")]
    public class MuscleGroup
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Column("name")]
        public required string Name { get; set; }

        public IEnumerable<ExerciseMuscleGroup> ExerciseMuscleGroups { get; set; } = [];
    }
}
