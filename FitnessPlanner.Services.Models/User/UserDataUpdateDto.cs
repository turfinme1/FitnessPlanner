using FitnessPlanner.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.ErrorMessages;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.GoalConstants;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.SkillLevelConstants;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.UserConstants;

namespace FitnessPlanner.Services.Models.User
{
    public class UserDataUpdateDto
    {
        [Required]
        public required string Id { get; set; }

        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = StringLengthErrorMessage)]
        public string Name { get; set; }

        [EnumDataType(typeof(Genders),
            ErrorMessage = EnumDataTypeErrorMessage)]
        public Genders Gender { get; set; }

        [Range(AgeMinLength,
            AgeMaxLength,
            ErrorMessage = RangeErrorMessage)]
        public int Age { get; set; }

        [Range(HeightMinLength,
            HeightMaxLength,
            ErrorMessage = RangeErrorMessage)]
        public double Height { get; set; }

        [Range(WeightMinLength,
            WeightMaxLength,
            ErrorMessage = RangeErrorMessage)]
        public double Weight { get; set; }

        [Range(SkillIdMinRange,
            SkillIdMaxRange,
            ErrorMessage = RangeErrorMessage)]
        public int SkillLevelId { get; set; }

        [Range(GoalIdMinRange,
            GoalIdMaxRange,
            ErrorMessage = RangeErrorMessage)]
        public int GoalId { get; set; }
    }
}
