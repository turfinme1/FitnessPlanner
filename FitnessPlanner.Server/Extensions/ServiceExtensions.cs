using FitnessPlanner.Data;
using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
using FitnessPlanner.Data.Repositories;
using Microsoft.AspNetCore.Identity;

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
            builder.AddScoped<IExercisePerformInfoRepository, ExercisePerformInfoRepository>();
            builder.AddScoped<IExerciseRepository, ExerciseRepository>();
            builder.AddScoped<ISingleWorkoutRepository, SingleWorkoutRepository>();
            builder.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.AddScoped<IWorkoutPlanRepository, WorkoutPlanRepository>();
        }
        
    }
}
