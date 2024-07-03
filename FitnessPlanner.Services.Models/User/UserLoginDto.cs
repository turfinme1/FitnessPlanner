using System.ComponentModel.DataAnnotations;
using static FitnessPlanner.Data.Models.Constants.ValidationConstants.ErrorMessages;

namespace FitnessPlanner.Services.Models.User
{
    public class UserLoginDto
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        public required string Email { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public required string Password { get; set; }
    }
}
