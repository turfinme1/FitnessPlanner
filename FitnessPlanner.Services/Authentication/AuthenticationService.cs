using Ardalis.Result;
using FitnessPlanner.Data.Models;
using FitnessPlanner.Services.Authentication.Contracts;
using FitnessPlanner.Services.BodyMassIndexCalculation.Contracts;
using FitnessPlanner.Services.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace FitnessPlanner.Services.Authentication
{
    public sealed class AuthenticationService(
        ILogger<AuthenticationService> logger,
        UserManager<User> userManager,
        IConfiguration configuration,
        IBodyMassIndexCalculationService bodyMassCalculationService) : IAuthenticationService
    {
        private User? _user;

        public async Task<Result> RegisterUserAsync(UserRegistrationDto model)
        {
            var user = new User
            {
                UserName = model.Email,
                Email = model.Email,
                Name = model.Name,
                Gender = model.Gender,
                Age = model.Age,
                Height = model.Height,
                Weight = model.Weight,
                SkillLevelId = model.SkillLevelId,
                GoalId = model.GoalId,
                BodyMassIndexMeasureId = bodyMassCalculationService.GetBodyMassIndexMeasureId(model.Weight, model.Height)
            };

            try
            {
                var result = await userManager.CreateAsync(user, model.Password);

                return result.Succeeded
                    ? Result.Success()
                    : Result.Error("Could not register user with provided email and password");
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(RegisterUserAsync)}: Could not register user");
                throw;
            }
        }

        public async Task<Result<string>> AuthenticateUserAsync(UserLoginDto model)
        {
            try
            {
                _user = await userManager.FindByEmailAsync(model.Email);

                var result = (_user is not null) && await userManager.CheckPasswordAsync(_user, model.Password);

                if (result is false)
                {
                    logger.LogWarning($"{nameof(AuthenticateUserAsync)}: Authentication failed. Wrong username or password");
                    return Result.Unauthorized();
                }

                return Result<string>.Success(await CreateToken());
            }
            catch (Exception e)
            {
                logger.LogError(e, $"Error in {nameof(AuthenticateUserAsync)}: Communicating with datastore failed");
                throw;
            }
        }

        private async Task<string> CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(configuration.GetSection("JwtSettings:Secret").Value!);

            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>()
            {
                new Claim("Name", _user.Name),
                new Claim(ClaimTypes.Email, _user.Email),
                new Claim(ClaimTypes.NameIdentifier, _user.Id)
            };

            var roles = await userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");

            var tokenOptions = new JwtSecurityToken(
                issuer: jwtSettings["ValidIssuer"],
                audience: jwtSettings["ValidAudience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings["ExpiryInMinutes"])),
                signingCredentials: signingCredentials);

            return tokenOptions;
        }
    }
}
