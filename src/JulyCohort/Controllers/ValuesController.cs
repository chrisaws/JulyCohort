using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace JulyCohort.Controllers;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] {"values1", "value2"};
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return "July Cohort";
    }

}