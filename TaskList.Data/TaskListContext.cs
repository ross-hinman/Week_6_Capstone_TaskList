using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using TaskList.Data.Maps;
using TaskList.Domain.Models;

namespace TaskList.Data
{
    public class TaskListContext :DbContext
    {
        public TaskListContext(): base("TaskList")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TaskListContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Configurations.Add(new UserMap());
        //    modelBuilder.Configurations.Add(new TaskMap());
        //    base.OnModelCreating(modelBuilder);

        //}
    }
}
