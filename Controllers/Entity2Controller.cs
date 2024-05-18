using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class Entity2Controller : ControllerBase
{
    [HttpGet]
    public IEnumerable<Entity2> Get()
    {
        return new List<Entity2> { new Entity2 { Id = 1, Description = "Description1" } };
    }
}
