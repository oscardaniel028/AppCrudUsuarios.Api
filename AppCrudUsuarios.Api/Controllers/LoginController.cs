using AppCrudUsuarios.Business.Interfaces;
using AppCrudUsuarios.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppCrudUsuarios.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public LoginController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            
            if (loginRequest == null || string.IsNullOrEmpty(loginRequest.Email) || string.IsNullOrEmpty(loginRequest.Password))
            {
                return BadRequest("Credenciales no proporcionadas.");
            }

           
                // Llamar al servicio de autenticación para realizar el login
                var token = await _authenticationService.LoginAsync(loginRequest);

                // Verificar si el usuario fue autenticado
                if (token != null)
                {
                    return Ok(token);
                }

                return NotFound("Usuario no encontrado");
            
            
        }
    }
}
