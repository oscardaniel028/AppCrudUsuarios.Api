using AppCrudUsuarios.Data.Entities;
using AppCrudUsuarios.Business.Models;

namespace AppCrudUsuarios.Business.Extensions
{
    public static class UserExtensions
    {
        public static UserModel Map (this UserEntity userEntity)
        {
            return new UserModel
            {
                Name = userEntity.Name,
                Password = userEntity.Password,
            };
        }

        public static UserEntity Map(this UserModel userModel)
        {
            return new UserEntity
            {
                Name = userModel.Name,
                Password = userModel.Password,
            };
        }
    }
}
