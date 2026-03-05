using Microsoft.EntityFrameworkCore;
using DeploymentTrackerAPI.Models;

namespace DeploymentTrackerAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Deployment> Deployments { get; set; }
}