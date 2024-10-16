using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppCrudUsuarios.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Get() {
            var countries = await Task.FromResult(new List<string> { "Colombia", "Brasil", "Francia" });
            return Ok(countries);
        }
    }
}
