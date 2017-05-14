namespace TaskService.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskService.Models.TaskContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TaskService.Models.TaskContext context)
        {
            context.Technicians.AddOrUpdate(x=>x.Id,
               new Technician() { Name = "Wakil Hasan"},
               new Technician() { Name = "Fariz Hasan"},
               new Technician() { Name = "Jane Austen"});

            context.ServiceJobs.AddOrUpdate(x => x.Id,
            new ServiceJob()
            {
        
                Name = "Pride and Prejudice",
                StartDate = DateTime.Parse("2010-09-01"),
                EndDate = DateTime.Parse("2011-09-01"),
                Status = "Done",
                Comment = "Comedy of manners",
                ClientID = 1
            },
            new ServiceJob()
            {
                Name = "Pride and Prejudice",
                StartDate = DateTime.Parse("2010-09-01"),
                EndDate = DateTime.Parse("2012-09-01"),
                Status = "Done",
                Comment = "Comedy of manners",
                ClientID = 1
            },
            new ServiceJob()
            {
                Name = "Pride and Prejudice",
                StartDate = DateTime.Parse("2015-09-01"),
                EndDate = (DateTime?)null,
                Status = "In Progress",
                Comment = "Comedy of manners",
                ClientID = 1
            },
            new ServiceJob()
            {
                Name = "Pride and Prejudice",
                StartDate = DateTime.Parse("2010-09-01"),
                EndDate = (DateTime?)null,
                Status = "Done",
                Comment = "Comedy of manners",
                ClientID = 1
            }
    );
        }
    }
}
