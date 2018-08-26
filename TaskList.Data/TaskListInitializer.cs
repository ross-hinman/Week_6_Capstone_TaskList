using System.Data.Entity;
using TaskList.Domain.Models;

namespace TaskList.Data
{
    internal class TaskListInitializer : DropCreateDatabaseAlways<TaskListContext>
    {

        protected override void Seed(TaskListContext context)
        {
            base.Seed(context);
        }
    }
}