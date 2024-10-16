using AppCrudUsuarios.Business.Models;

namespace AppCrudUsuarios.Business.Interfaces
{
    public interface IAuthenticationService
    {
        public Task<string> LoginAsync(LoginRequest loginRequest);

    }
}
