using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessPlanner.Data.Models
{
    [Table("workout_plan_body_mass_index_measure")]
    [PrimaryKey(nameof(WorkoutPlanId), nameof(BodyMassIndexMeasureId))]
    public class WorkoutPlanBodyMassIndexMeasure
    {
        [Column("workout_plan_id")]
        public int WorkoutPlanId { get; set; }

        [ForeignKey(nameof(WorkoutPlanId))]
        public WorkoutPlan WorkoutPlan { get; set; } = null!;

        [Column("body_mass_index_measure_id")]
        public int BodyMassIndexMeasureId { get; set; }

        [ForeignKey(nameof(BodyMassIndexMeasureId))]
        public BodyMassIndexMeasure BodyMassIndexMeasure { get; set; } = null!;
    }
}
