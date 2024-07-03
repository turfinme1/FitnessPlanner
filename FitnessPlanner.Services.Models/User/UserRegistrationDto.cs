using FitnessPlanner.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.ErrorMessages;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.GoalConstants;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.SkillLevelConstants;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.UserConstants;

namespace FitnessPlanner.Services.Models.User
{
    public class UserRegistrationDto
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
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
        [Range(AgeMinLength, AgeMaxLength,
            ErrorMessage = RangeErrorMessage)]
        public int Age { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(HeightMinLength, HeightMaxLength,
            ErrorMessage = RangeErrorMessage)]
        public double Height { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(WeightMinLength, WeightMaxLength,
            ErrorMessage = RangeErrorMessage)]
        public double Weight { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EnumDataType(typeof(Genders), 
            ErrorMessage = EnumDataTypeErrorMessage)]
        public Genders Gender { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(SkillIdMinRange, SkillIdMaxRange,
            ErrorMessage = RangeErrorMessage)]
        public int SkillLevelId { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(GoalIdMinRange, GoalIdMaxRange,
            ErrorMessage = RangeErrorMessage)]
        public int GoalId { get; set; }
    }
}
