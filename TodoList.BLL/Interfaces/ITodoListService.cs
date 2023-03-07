using System;
using System.Collections.Generic;
using System.Text;
using TodoList.BLL.Models;
using TodoList.DAL.Entities;

namespace TodoList.BLL.Interfaces
{
    public interface ITodoListService
    {
        void Add(AddOrUpdateTaskVM model);
        void Delete(int userId, int taskId);
        void Update(AddOrUpdateTaskVM model);
        void MarkAsDone(int userId, int taskId);
        Todo GetTask(int userId, int taskId);
        IEnumerable<Todo> GetTodoList();

    }
}
