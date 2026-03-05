using DeploymentTrackerAPI.Data;
using DeploymentTrackerAPI.Models;

namespace DeploymentTrackerAPI.Services;

public class DeploymentService
{
    private readonly AppDbContext _context;

    public DeploymentService(AppDbContext context)
    {
        _context = context;
    }

    public List<Deployment> GetAll()
    {
        return _context.Deployments.ToList();
    }

    public void Add(Deployment deployment)
    {
        deployment.DeploymentTime = DateTime.Now;
        _context.Deployments.Add(deployment);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var item = _context.Deployments.Find(id);

        if (item != null)
        {
            _context.Deployments.Remove(item);
            _context.SaveChanges();
        }
    }
}