using FitnessPlanner.Services.Models.SingleWorkout;
using System.ComponentModel.DataAnnotations;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.ErrorMessages;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.WorkoutPlanConstants;

namespace FitnessPlanner.Services.Models.WorkoutPlan
{
    public class WorkoutPlanCreateDto
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public required string Name { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public required string UserId { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int SkillLevelId { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public int GoalId { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public required IEnumerable<SingleWorkoutCreateDto> SingleWorkouts { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public required IEnumerable<int> BodyMassIndexMeasures { get; set; }
    }
}
