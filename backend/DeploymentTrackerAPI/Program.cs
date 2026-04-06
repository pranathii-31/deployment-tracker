using Microsoft.EntityFrameworkCore;
using DeploymentTrackerAPI.Data;
using DeploymentTrackerAPI.Services;

var builder = WebApplication.CreateBuilder(args);
// removed: builder.WebHost.UseWebRoot("wwwroot");

// Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    var dbPath = Path.Combine(builder.Environment.ContentRootPath, "deployments.db");
    options.UseSqlite($"Data Source={dbPath}");
});

builder.Services.AddScoped<DeploymentService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy
            .WithOrigins("http://20.224.45.57:81")
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

app.UseCors("AllowAngular");
app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "DeploymentTracker API V1");
    c.RoutePrefix = "swagger";
});

// removed: app.UseDefaultFiles();
// removed: app.UseStaticFiles();

app.MapControllers();

app.Run();
