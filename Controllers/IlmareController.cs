using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ilmare.Controllers;

[ApiController]
// [Route("[controller]")] => https://localhost:7130/
// [Route("[Ilmarecontroller]")] => https://localhost:7130/Ilmare
[Route("[controller]")]
public class Controller : ControllerBase
{
    private readonly ILogger<Controller> _logger;

    public Controller(ILogger<Controller> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Foo")]
    public History Get()
    {
        var post = new Post(1, "Test", "http://", "Ja", "Nej", "DateTime.Now.toString()");
        var posts = new List<Post>();
        posts.Add(post);

        var history = new History()
        {
            Posts = posts
        };
        
        return history;
    }
}
