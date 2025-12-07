using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using VisionFlowAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Load .env
Env.Load();

var connectionString = Environment.GetEnvironmentVariable("DATABASE_URL");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString)
);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
