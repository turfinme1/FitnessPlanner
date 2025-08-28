using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.ErrorMessages;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.ExerciseConstants;
namespace FitnessPlanner.Services.Models.Exercise
{
    public class ExerciseCreateDto
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(NameMaxLength, 
            MinimumLength = NameMinLength, 
            ErrorMessage = StringLengthErrorMessage)]
        public required string Name { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(ExplanationMaxLength,
            MinimumLength = ExplanationMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public required string Explanation { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(PerformTipMaxLength,
            MinimumLength = PerformTipMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public required string PerformTip { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(ImageNameMaxLength,
            MinimumLength = ImageNameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public required string ImageName { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public required IEnumerable<int> MuscleGroups { get; set; } = new List<int>();

        [Required(ErrorMessage = RequiredErrorMessage)]
        public required IFormFile File { get; set; } 
    }
}
