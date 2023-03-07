using System;
using System.Collections.Generic;
using TodoList.BLL.Interfaces;
using TodoList.BLL.Models;
using TodoList.DAL.Entities;

namespace TodoList.BLL.Implementations
{
    public class TodoListService : ITodoListService
    {
        public void Add(AddOrUpdateTaskVM model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int userId, int taskId)
        {
            throw new NotImplementedException();
        }

        public void Update(AddOrUpdateTaskVM model)
        {
            throw new NotImplementedException();
        }

        public void MarkAsDone(int userId, int taskId)
        {
            throw new NotImplementedException();
        }

        public Todo GetTask(int userId, int taskId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Todo> GetTodoList()
        {
            throw new NotImplementedException();
        }
    }
}