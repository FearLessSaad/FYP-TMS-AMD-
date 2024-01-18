using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TMS.Context;
using TMS.Models;

namespace TMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DatabaseContext _dbContext;

        public AuthController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("designation/all")]
        public async Task<ActionResult<Designation>> getAllDesignations()
        {
            return Ok(await _dbContext.Designations.ToListAsync());
        }
    }
}
