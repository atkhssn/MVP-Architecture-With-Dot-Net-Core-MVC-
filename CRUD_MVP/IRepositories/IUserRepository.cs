using CRUD_MVP.Models;

namespace CRUD_MVP.IRepositories
{
    public interface IUserRepository
    {
        UserModel GetUserById(int id);
        IEnumerable<UserModel> GetAllUsers();
    }
}
