using CRUD_MVP.IRepositories;
using CRUD_MVP.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace CRUD_MVP.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<UserModel> users = new List<UserModel>();

        public UserRepository()
        {
            UserModel userOne = new UserModel { Id = 1, Name = "Atik Hassan", Email = "atik@hassan.com" };
            UserModel userTwo = new UserModel { Id = 2, Name = "Hassan Atik", Email = "hassan@atik.com" };
            users.Add(userOne);
            users.Add(userTwo);
        }

        public IEnumerable<UserModel> GetAllUsers()
        {
            return users;
        }


        public UserModel GetUserById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }
    }
}
