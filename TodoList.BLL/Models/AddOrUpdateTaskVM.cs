using System;
using System.Collections.Generic;
using System.Text;
using TodoList.DAL.Enums;

namespace TodoList.BLL.Models
{
    public class AddOrUpdateTaskVM
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority? Priority { get; set; }
        public DateTime DueDate { get; set; }
    }
}
