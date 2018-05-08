using System;
namespace Capstone2_TaskList
{
    public class AddTask
    {

        public string TaskOwner { get; set; }
        public string TaskName { get; set; }
        public string DueDate { get; set; }
        public bool Complete { get; set; }
            
        public AddTask(bool complete, string taskOwner, string taskName, string dueDate)
        {
            TaskOwner = taskOwner;
            TaskName = taskName;
            DueDate = dueDate;
            Complete = false;
        }
    }
}