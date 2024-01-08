namespace DatingApp.Controllers
{
    using DatingApp.Database;
    using DatingApp.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;


    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context) 
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
