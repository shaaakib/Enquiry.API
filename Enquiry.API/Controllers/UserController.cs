using Enquiry.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Enquiry.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowCors")]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _db;
        public UserController(UserDbContext db)
        {
            _db = db;
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser([FromBody] User obj)
        {
            var user = _db.Users.SingleOrDefault(m => m.email == obj.email);
            if (user != null)
            {
                return BadRequest("User already exists");
            }
            _db.Users.Add(obj);
            _db.SaveChanges();

            return Created("User Registers success", obj);
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserLoginDto obj)
        {
            var user = _db.Users.SingleOrDefault(m => m.email == obj.email && m.password == obj.password);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound("Invalid User");
        }

        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            var users = _db.Users.ToList();
            return Ok(users);
        }
    }
}
