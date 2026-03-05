using Microsoft.AspNetCore.Mvc;
using DeploymentTrackerAPI.Models;
using DeploymentTrackerAPI.Services;

namespace DeploymentTrackerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DeploymentsController : ControllerBase
{
    private readonly DeploymentService _service;

    public DeploymentsController(DeploymentService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetDeployments()
    {
        return Ok(_service.GetAll());
    }

    [HttpPost]
    public IActionResult AddDeployment(Deployment deployment)
    {
        _service.Add(deployment);
        return Ok(deployment);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteDeployment(int id)
    {
        _service.Delete(id);
        return Ok();
    }
}