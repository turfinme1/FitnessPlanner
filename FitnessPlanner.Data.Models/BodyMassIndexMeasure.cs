﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.BodyMassIndexMeasureConstants;

namespace FitnessPlanner.Data.Models
{
    [Table("body_mass_index_measure")]
    public class BodyMassIndexMeasure
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TypeMaxLength)]
        [Column("type")]
        public required string Type { get; set; }

        public IEnumerable<User> Users { get; set; } = new List<User>();

        public IEnumerable<WorkoutPlanBodyMassIndexMeasure> WorkoutPlanBodyMassIndexMeasures { get; set; } = new List<WorkoutPlanBodyMassIndexMeasure>();
    }
}
