namespace DeploymentTrackerAPI.Models;

public class Deployment
{
    public int Id { get; set; }
    public string AppName { get; set; }
    public string Version { get; set; }
    public string Environment { get; set; }
    public string Status { get; set; }
    public DateTime DeploymentTime { get; set; }
}