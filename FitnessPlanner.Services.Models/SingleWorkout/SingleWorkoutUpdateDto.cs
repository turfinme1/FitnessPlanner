using FitnessPlanner.Data.Models.Enums;
using FitnessPlanner.Services.Models.ExercisePerformInfo;
using System.ComponentModel.DataAnnotations;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.ErrorMessages;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.SingleWorkoutConstants;

namespace FitnessPlanner.Services.Models.SingleWorkout
{
    public class SingleWorkoutUpdateDto
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public required string Name { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public DaysOfWeek Day { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public required IEnumerable<ExercisePerformInfoUpdateDto> ExercisePerformInfos { get; set; }
    }
}
