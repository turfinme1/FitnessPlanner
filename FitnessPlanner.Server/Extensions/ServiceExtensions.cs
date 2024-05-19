using Azure.Identity;
using Azure.Storage.Blobs;
using FitnessPlanner.Data;
using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
using FitnessPlanner.Data.Repositories;
using FitnessPlanner.Services.ApplicationUser;
using FitnessPlanner.Services.ApplicationUser.Contracts;
using FitnessPlanner.Services.Authentication;
using FitnessPlanner.Services.Authentication.Contracts;
using FitnessPlanner.Services.FilePersistence;
using FitnessPlanner.Services.FilePersistence.Contracts;
using FitnessPlanner.Services.WorkoutPlan;
using FitnessPlanner.Services.WorkoutPlan.Contracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using FitnessPlanner.Services.Admin;
using FitnessPlanner.Services.Admin.Contracts;
using FitnessPlanner.Services.BodyMassIndexCalculation;
using FitnessPlanner.Services.BodyMassIndexCalculation.Contracts;

namespace FitnessPlanner.Server.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureIdentity(this IServiceCollection builder)
        {
            builder.AddIdentity<User, IdentityRole>(options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequiredLength = 6;
                    options.Password.RequireLowercase = false;
                    options.User.RequireUniqueEmail = true;
                    options.SignIn.RequireConfirmedEmail = false;
                })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        }

        public static void ConfigureApplicationServices(this IServiceCollection builder)
        {
            builder.AddSingleton<BlobServiceClient>(x =>
                new BlobServiceClient(
                    new Uri("https://artshopimgs.blob.core.windows.net"),
                    new DefaultAzureCredential()));

            builder.AddScoped<IExercisePerformInfoRepository, ExercisePerformInfoRepository>();
            builder.AddScoped<IExerciseRepository, ExerciseRepository>();
            builder.AddScoped<ISingleWorkoutRepository, SingleWorkoutRepository>();
            builder.AddScoped<IWorkoutPlanRepository, WorkoutPlanRepository>();
            builder.AddScoped<IUserRepository, UserRepository>();
            builder.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.AddScoped<IAuthenticationService, AuthenticationService>();
            builder.AddScoped<IFilePersistenceService, FilePersistenceService>();
            builder.AddScoped<IBodyMassIndexCalculationService, BodyMassIndexCalculationService>();
            builder.AddScoped<IWorkoutPlanService, WorkoutPlanService>();
            builder.AddScoped<IUserService, UserService>();
            builder.AddScoped<IAdminService, AdminService>();
        }

        public static void ConfigureJwt(this IServiceCollection builder, IConfiguration configuration)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var key = jwtSettings.GetSection("Secret").Value!;
            var issuer = jwtSettings.GetSection("ValidIssuer").Value!;
            var audience = jwtSettings.GetSection("ValidAudience").Value!;

            builder.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = issuer,
                        ValidAudience = audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
                    };
                });
        }
    }
}
