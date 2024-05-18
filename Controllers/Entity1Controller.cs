using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class Entity1Controller : ControllerBase
{
    [HttpGet]
    public IEnumerable<Entity1> Get()
    {
        return new List<Entity1> { new Entity1 { Id = 1, Name = "Item1" } };
    }
}
