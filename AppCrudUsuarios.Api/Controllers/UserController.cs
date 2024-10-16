using AppCrudUsuarios.Business.Interfaces;
using AppCrudUsuarios.Business.Models;
using Microsoft.AspNetCore.Mvc;


namespace AppCrudUsuarios.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        // Obtener todos los usuarios
        [HttpGet]
        public IActionResult GetAllUsers ()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }
        // Obtener un usuario por nombre
        [HttpGet("search")]
        public IActionResult GetUserByName(string name)
        {
            var user = _userService.GetUserByName(name);    

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserModel user)
        {
            _userService.AddUser(user);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser (int id, [FromBody] UserModel user)
        {
            var existingUser = _userService.GetUser(id);
            if (existingUser == null)
            {
                return NotFound();
            }
            _userService.UpdateUser(id, user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var existingUser = _userService.GetUser(id);
            if (existingUser == null)
            {
                return NotFound();
            }

            _userService.DeleteUser(id);
            return Ok();
        }
    }
}
