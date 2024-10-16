using AppCrudUsuarios.Business.Models;

namespace AppCrudUsuarios.Business.Interfaces
{
    public interface IUserService
    {
        UserModel GetUser(int id);
        IEnumerable<UserModel> GetAllUsers();
        UserModel GetUserByName(string name);
        void AddUser (UserModel user);
        void UpdateUser (int id, UserModel user);
        void DeleteUser (int id);
    }
}
