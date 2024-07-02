using CRUD_MVP.IRepositories;
using CRUD_MVP.Views.User.Interface;

namespace CRUD_MVP.Presenter
{
    public class UserPresenter
    {
        private readonly IUserView _userView;
        private readonly IUserRepository _userRepository;

        public UserPresenter(IUserView userView, IUserRepository userRepository)
        {
            _userView = userView;
            _userRepository = userRepository;
        }

        public void LoadUser(int id)
        {
            var user = _userRepository.GetUserById(id);
            _userView.DisplayUser(user);
        }

        public void LoadAllUsers()
        {
            var users = _userRepository.GetAllUsers();
            _userView.DisplayAllUsers(users);
        }
    }
}
