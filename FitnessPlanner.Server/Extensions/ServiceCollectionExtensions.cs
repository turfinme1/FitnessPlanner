﻿using Azure.Identity;
using Azure.Storage.Blobs;
using FitnessPlanner.Data;
using FitnessPlanner.Data.Contracts;
using FitnessPlanner.Data.Models;
using FitnessPlanner.Data.Repositories;
using FitnessPlanner.Server.Filters;
using FitnessPlanner.Server.Middlewares;
using FitnessPlanner.Services.Admin;
using FitnessPlanner.Services.Admin.Contracts;
using FitnessPlanner.Services.ApplicationUser;
using FitnessPlanner.Services.ApplicationUser.Contracts;
using FitnessPlanner.Services.Authentication;
using FitnessPlanner.Services.Authentication.Contracts;
using FitnessPlanner.Services.BodyMassIndexCalculation;
using FitnessPlanner.Services.BodyMassIndexCalculation.Contracts;
using FitnessPlanner.Services.BodyMassIndexMeasure;
using FitnessPlanner.Services.BodyMassIndexMeasure.Contracts;
using FitnessPlanner.Services.CosineSimilarityCalculation;
using FitnessPlanner.Services.CosineSimilarityCalculation.Contracts;
using FitnessPlanner.Services.Exercise;
using FitnessPlanner.Services.Exercise.Contracts;
using FitnessPlanner.Services.FilePersistence;
using FitnessPlanner.Services.FilePersistence.Contracts;
using FitnessPlanner.Services.Goal;
using FitnessPlanner.Services.Goal.Contracts;
using FitnessPlanner.Services.SkillLevel;
using FitnessPlanner.Services.SkillLevel.Contracts;
using FitnessPlanner.Services.WorkoutPlan;
using FitnessPlanner.Services.WorkoutPlan.Contracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text;

namespace FitnessPlanner.Server.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureDatastore(this IServiceCollection builder, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionString));
        }

        public static void ConfigureModelValidation(this IServiceCollection builder)
        {
            builder.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
            builder.AddControllers(options =>
            {
                options.Filters.Add<ModelValidationFilter>();
            });
        }

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
            builder.AddSingleton<
                IAuthorizationMiddlewareResultHandler, AuthorizationResultHandler>();

            builder.AddSingleton<BlobServiceClient>(x =>
                new BlobServiceClient(
                    new Uri("https://artshopimgs.blob.core.windows.net"),
                    new DefaultAzureCredential()));

            builder.AddScoped<IExercisePerformInfoRepository, ExercisePerformInfoRepository>();
            builder.AddScoped<IExerciseRepository, ExerciseRepository>();
            builder.AddScoped<ISingleWorkoutRepository, SingleWorkoutRepository>();
            builder.AddScoped<IWorkoutPlanRepository, WorkoutPlanRepository>();
            builder.AddScoped<IUserRepository, UserRepository>();
            builder.AddScoped<ISkillLevelRepository, SkillLevelRepository>();
            builder.AddScoped<IGoalRepository, GoalRepository>();
            builder.AddScoped<IBodyMassIndexMeasureRepository, BodyMassIndexMeasureRepository>();
            builder.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.AddScoped<IAuthenticationService, AuthenticationService>();
            builder.AddScoped<IFilePersistenceService, FilePersistenceService>();
            builder.AddScoped<IBodyMassIndexCalculationService, BodyMassIndexCalculationService>();
            builder.AddScoped<ICosineSimilarityCalculationService, CosineSimilarityCalculationService>();
            builder.AddScoped<IWorkoutPlanService, WorkoutPlanService>();
            builder.AddScoped<IGoalService, GoalService>();
            builder.AddScoped<ISkillLevelService, SkillLevelService>();
            builder.AddScoped<IBodyMassIndexMeasureService, BodyMassIndexMeasureService>();
            builder.AddScoped<IUserService, UserService>();
            builder.AddScoped<IAdminService, AdminService>();
            builder.AddScoped<IExerciseService, ExerciseService>();
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

        public static void ConfigureSwagger(this IServiceCollection builder)
        {
            builder.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Name = "Bearer"
                        },
                        new List<string>()
                    },
                });

                options.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Version = "v1",
                    Title = "Fitness Planner",
                    Description = "API for Fitness Planner application",
                    Contact = new OpenApiContact()
                    {
                        Name = "Borislav Angelov",
                        Email = "borislav.m.angelov@gmail.com"
                    },
                    License = new OpenApiLicense()
                    {
                        Name = "MIT",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }
                });

                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory,
                    $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"), true);
            });
        }
    }
}
