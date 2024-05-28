using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessPlanner.Data.Models
{
    /// <summary>
    /// Represents the relationship between a <see cref="WorkoutPlan"/> and a <see cref="BodyMassIndexMeasure"/>.
    /// </summary>
    [Table("workout_plan_body_mass_index_measure")]
    [PrimaryKey(nameof(WorkoutPlanId), nameof(BodyMassIndexMeasureId))]
    public class WorkoutPlanBodyMassIndexMeasure
    {
        /// <summary>
        /// The ID of the associated workout plan.
        /// </summary>
        [Column("workout_plan_id")]
        [Comment("The ID of the associated workout plan.")]
        public int WorkoutPlanId { get; set; }

        /// <summary>
        /// The workout plan associated with this relationship.
        /// </summary>
        [ForeignKey(nameof(WorkoutPlanId))]
        public WorkoutPlan WorkoutPlan { get; set; } = null!;

        /// <summary>
        /// The ID of the associated body mass index measure.
        /// </summary>
        [Column("body_mass_index_measure_id")]
        [Comment("The ID of the associated body mass index measure.")]
        public int BodyMassIndexMeasureId { get; set; }

        /// <summary>
        /// The body mass index measure associated with this relationship.
        /// </summary>
        [ForeignKey(nameof(BodyMassIndexMeasureId))]
        public BodyMassIndexMeasure BodyMassIndexMeasure { get; set; } = null!;
    }
}
