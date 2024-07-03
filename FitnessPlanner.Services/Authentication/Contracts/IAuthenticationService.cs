using FitnessPlanner.Services.Models.User;
using Microsoft.AspNetCore.Identity;

namespace FitnessPlanner.Services.Authentication.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUserAsync(UserRegistrationDto model);

        Task<bool> AuthenticateUserAsync(UserLoginDto model);

        Task<string> CreateToken();
    }
}
