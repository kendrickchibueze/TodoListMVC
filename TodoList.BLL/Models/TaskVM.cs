namespace TodoList.BLL.Models
{
    public class TaskVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string DueDate { get; set; }
        public string Status { get; set; }
    }
}