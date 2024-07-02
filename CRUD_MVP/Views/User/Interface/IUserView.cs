using CRUD_MVP.Models;

namespace CRUD_MVP.Views.User.Interface
{
    public interface IUserView
    {
        void DisplayAllUsers(IEnumerable<UserModel> users);
        void DisplayUser(UserModel user);
    }
}
