using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Api.Controllers;

[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
