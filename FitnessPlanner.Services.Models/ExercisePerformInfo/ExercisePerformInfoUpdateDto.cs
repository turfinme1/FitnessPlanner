using System.ComponentModel.DataAnnotations;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.ErrorMessages;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.ExercisePerformInfoConstants;

namespace FitnessPlanner.Services.Models.ExercisePerformInfo
{
    public class ExercisePerformInfoUpdateDto
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        public int ExerciseId { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(SetsMinValue, SetsMaxValue,
            ErrorMessage = RangeErrorMessage)]
        public int Sets { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(RepsMinValue, RepsMaxValue,
            ErrorMessage = RangeErrorMessage)]
        public int Reps { get; set; }
    }
}
