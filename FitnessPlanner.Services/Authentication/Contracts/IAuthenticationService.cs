using Ardalis.Result;
using FitnessPlanner.Services.Models.User;

namespace FitnessPlanner.Services.Authentication.Contracts
{
    public interface IAuthenticationService
    {
        Task<Result> RegisterUserAsync(UserRegistrationDto model);

        Task<Result<string>> AuthenticateUserAsync(UserLoginDto model);
    }
}
