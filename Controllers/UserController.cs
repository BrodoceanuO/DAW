using DAW2.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAW2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;

        UserController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet("getUsers")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _databaseContext.DataBaseModels.ToListAsync());
        }
    }
}
