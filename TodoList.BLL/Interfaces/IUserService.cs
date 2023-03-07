using System.Collections.Generic;
using TodoList.BLL.Models;
using TodoList.DAL.Entities;

namespace TodoList.BLL.Interfaces
{
    public interface IUserService
    {
        void Create(CreateUserVM model);
        IEnumerable<User> GetUsers();
        IEnumerable<UserWithTaskVM> GetUsersWithTasks();
    }
}