
using Microsoft.AspNetCore.Mvc;
using test_api.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace test_api.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UsersController : ControllerBase
    {
        private readonly DBContext _context;

        public UsersController(DBContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(){
            List<User> users= await _context.Users.ToListAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUser([FromBody]User user){
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetAll",user);

        }
    }
}