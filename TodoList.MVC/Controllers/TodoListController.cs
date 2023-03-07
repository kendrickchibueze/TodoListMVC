using Microsoft.AspNetCore.Mvc;
using TodoList.BLL.Interfaces;

namespace TodoList.MVC.Controllers
{
    public class TodoListController : Controller
    {
        private readonly IUserService _userService;

        public TodoListController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            var model = _userService.GetUsersWithTasks();

            return View(model);
        }
    }
}
