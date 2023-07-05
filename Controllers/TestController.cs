using BaseApp.API.Db;
using BaseApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("/test/getfromdb")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly BaseDbContext _context;

    public TestController(BaseDbContext context)
    {
        _context = context;
    }

    // GET: /test/getfromdb
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Test>>> GetTests()
    {
        return await _context.Tests.ToListAsync();
    }
}
