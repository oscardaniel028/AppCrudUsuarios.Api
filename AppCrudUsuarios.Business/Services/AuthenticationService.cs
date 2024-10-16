using AppCrudUsuarios.Business.Interfaces;
using AppCrudUsuarios.Business.Models;
using AppCrudUsuarios.Data;
using AppCrudUsuarios.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppCrudUsuarios.Business.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserDbContext _userDbContext;
        private readonly JwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(UserDbContext userDbContext, JwtTokenGenerator jwtTokenGenerator)
        {
            _userDbContext = userDbContext;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<string> LoginAsync(LoginRequest loginRequest)
        {
            UserEntity user = await _userDbContext.Users.FirstOrDefaultAsync(u => u.Name == loginRequest.Email && u.Password == loginRequest.Password);

            if (user != null)
            {
                return _jwtTokenGenerator.GenerateToken(user);
            }
            return null;
        }
    }
}
