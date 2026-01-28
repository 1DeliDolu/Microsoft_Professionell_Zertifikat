using Microsoft.AspNetCore.Mvc;

namespace SwaggerClientIntegrationApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet("{id:int}")]
    public ActionResult<User> Get(int id)
    {
        var user = new User
        {
            Id = id,
            Name = $"User {id}"
        };

        return Ok(user);
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
