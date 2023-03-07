using System;
using System.Collections.Generic;
using System.Text;
using TodoList.DAL.Enums;

namespace TodoList.DAL.Entities
{
    public class ToDoListDbContext
    {
        public static IList<User> GetUsersWithToDos()
        {
            return new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FullName = "John Doe",
                    Email = "john.doe@domain.com",
                    Password = "123445678",
                    TodoList = new List<Todo>()
                    {
                        new Todo
                        {
                            Id = 1,
                            Title = "Build Project",
                            Description = "Building a project",
                            Priority = Priority.High,
                            DueDate = DateTime.Now.AddDays(3)

                        },

                        new Todo
                        {
                            Id = 2,
                            Title = "Build Project2",
                            Description = "Building a project2",
                            Priority = Priority.Low,
                            DueDate = DateTime.Now,
                            IsDone = true

                        },
                        new Todo
                        {
                            Id = 3,
                            Title = "Build Project3",
                            Description = "Building a project3",
                            DueDate = DateTime.Now.AddDays(23)

                        }
                    }

                },
                new User()
                {
                    Id = 2,
                    FullName = "Chizoba Doe",
                    Email = "chizoba.doe@domain.com",
                    Password = "123445678",
                    TodoList = new List<Todo>()
                    {
                        new Todo
                        {
                            Id = 1,
                            Title = "Start Project",
                            Description = "Starting a project",
                            DueDate = DateTime.Now.AddDays(3)

                        },

                        new Todo
                        {
                            Id = 2,
                            Title = "Plan Project2",
                            Description = "Planing a project2",
                            Priority = Priority.High,
                            DueDate = DateTime.Now.AddDays(9),

                        },
                        new Todo
                        {
                            Id = 3,
                            Title = "Deliver Project3",
                            Description = "Delivering a project3",
                            DueDate = DateTime.Now,
                            IsDone = true

                        }
                    }

                }
            };
        }
    }
}
