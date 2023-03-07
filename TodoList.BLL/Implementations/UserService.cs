using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoList.BLL.Interfaces;
using TodoList.BLL.Models;
using TodoList.DAL.Entities;

namespace TodoList.BLL.Implementations
{
    public class UserService : IUserService
    {
        public void Create(CreateUserVM model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserWithTaskVM> GetUsersWithTasks()
        {
            return ToDoListDbContext.GetUsersWithToDos().Select(u => new UserWithTaskVM
            {
                Fullname = u.FullName,
                Tasks = u.TodoList.Select(t => new TaskVM
                {
                    Title = t.Title,
                    Description = t.Description,
                    DueDate = t.DueDate.ToString("d"),
                    Priority = t.Priority.ToString(),
                    Status = t.IsDone ? "Done" : "Not Done"
                })
            }).ToList();
        }
    }
}
