using FitnessPlanner.Server.Extensions;
using FitnessPlanner.Server.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the DI container.
builder.Services.ConfigureDatastore(builder.Configuration);

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();

builder.Services.ConfigureIdentity();

builder.Services.ConfigureJwt(builder.Configuration);

builder.Services.ConfigureApplicationServices();

builder.Services.ConfigureModelValidation();

builder.Services.AddEndpointsApiExplorer();

builder.Services.ConfigureSwagger();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler(_ => { });

app.UseDefaultFiles();
app.UseStaticFiles();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

await app.RunAsync();
