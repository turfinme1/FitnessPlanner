using FitnessPlanner.Data.Models.Constants;
using FitnessPlanner.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.ErrorMessages;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.UserConstants;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.SkillLevelConstants;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.GoalConstants;

namespace FitnessPlanner.Services.Models.User
{
    public class UserRegistrationDto
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength)]
        public required string Name { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]
        [StringLength(EmailMaxLength,
            MinimumLength = EmailMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public required string Email { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(PasswordMaxLength,
            MinimumLength = PasswordMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public required string Password { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(AgeMinLength,
            AgeMaxLength,
            ErrorMessage = NumberValueErrorMessage)]
        public int Age { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(HeightMinLength,
            HeightMaxLength,
            ErrorMessage = NumberValueErrorMessage)]
        public double Height { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(WeightMinLength,
            WeightMaxLength,
            ErrorMessage = NumberValueErrorMessage)]
        public double Weight { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EnumDataType(typeof(Genders))]
        public Genders Gender { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(SkillIdMinRange, SkillIdMaxRange)]
        public int? SkillLevelId { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(GoalIdMinRange, GoalIdMaxRange)]
        public int? GoalId { get; set; }
    }
}
