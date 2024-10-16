using AppCrudUsuarios.Business.Interfaces;
using AppCrudUsuarios.Business.Models;
using AppCrudUsuarios.Data.Entities;
using AppCrudUsuarios.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using AppCrudUsuarios.Business.Extensions;

namespace AppCrudUsuarios.Business.Services
{
    public class UserService : IUserService
    {
        private readonly UserDbContext _dbContext;

        public UserService(UserDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public UserModel GetUser(int id)
        {
            var user = _dbContext.Users.Find(id);
            return user?.Map();
        }

        public IEnumerable<UserModel> GetAllUsers()
        {
            return _dbContext.Users.Select(user => user.Map()).ToList();
        }

        public UserModel GetUserByName(string name)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Name == name);
            return user?.Map();
        }

        public void AddUser(UserModel userModel)
        {
            var userEntity = userModel.Map();
            _dbContext.Users.Add(userEntity);
            _dbContext.SaveChanges();
        }

        public void UpdateUser(int id, UserModel userModel)
        {
            var user = _dbContext.Users.Find(id);
            if (user != null)
            {
                user.Name = userModel.Name;
                user.Password = userModel.Password;
                _dbContext.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            var user = _dbContext.Users.Find(id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }
    }
}
