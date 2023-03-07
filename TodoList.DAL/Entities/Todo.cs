﻿using System;
using System.Collections.Generic;
using System.Text;
using TodoList.DAL.Enums;

namespace TodoList.DAL.Entities
{
    public class Todo : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; } = Priority.Normal;
        public DateTime DueDate { get; set;}
        public bool IsDone { get; set; }
    }
}
