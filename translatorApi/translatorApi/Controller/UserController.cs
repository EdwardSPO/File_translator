using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using translatorApi.Core.UserManager;
using translatorApi.Data;
using translatorApi.Models;

namespace translatorApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UsersContext _context;

        private readonly IUserManager _userManager;

        public UserController(UsersContext context, IUserManager userManager)
        {
            _context = context;
            _userManager = userManager;


        }

      

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var users = await _context.Users.FirstOrDefaultAsync(s => s.Id == id);
            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult> Post(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }



       

      

    }
}
