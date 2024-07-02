using CRUD_MVP.IRepositories;
using CRUD_MVP.Models;
using CRUD_MVP.Presenter;
using CRUD_MVP.Views.User.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_MVP.Controllers
{
    public class UserController : Controller, IUserView
    {
        private readonly UserPresenter _presenter;

        public UserController(IUserRepository userRepository)
        {
            _presenter = new UserPresenter(this, userRepository);
        }

        public IActionResult Index()
        {
            _presenter.LoadAllUsers();
            return View();
        }

        public IActionResult Details(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            _presenter.LoadUser(id);
            return View();
        }

        public void DisplayAllUsers(IEnumerable<UserModel> users)
        {
            ViewData["users"] = users;
        }

        public void DisplayUser(UserModel user)
        {
            ViewData["user"] = user;
        }
    }
}
