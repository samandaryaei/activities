using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    private readonly DataContext _dataContext;
    public ValuesController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Value>>> Get()
    {
        var values = await _dataContext.Values.ToListAsync();
        return Ok(values);
    }

    [HttpGet("{Id}")]
    public async Task<ActionResult<Value>> Get(int Id)
    {
        var value = await _dataContext.Values.FindAsync(Id);
        return Ok(value);
    }

    [HttpGet("SayHelloWorld")]
    public ActionResult<string> SayHelloWorld()
    {
        return Ok("Hello World !!");
    }
}
