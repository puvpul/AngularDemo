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
               new Technician() { Name = "Wakil Hasan", ImageUrl = "image(1).jpg"},
               new Technician() { Name = "Fariz Hasan", ImageUrl = "image(2).jpg" },
               new Technician() { Name = "Jane Austen", ImageUrl = "image(3).jpg" });

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
                Name = "Pride and Prejudice 2",
                StartDate = DateTime.Parse("2010-09-01"),
                EndDate = DateTime.Parse("2012-09-01"),
                Status = "Done",
                Comment = "Comedy of manners",
                ClientID = 1
            },
            new ServiceJob()
            {
                Name = "Pride and Prejudice 3",
                StartDate = DateTime.Parse("2015-09-01"),
                EndDate = (DateTime?)null,
                Status = "In Progress",
                Comment = "Comedy of manners",
                ClientID = 2
            },
            new ServiceJob()
            {
                Name = "Pride and Prejudice 4",
                StartDate = DateTime.Parse("2010-09-01"),
                EndDate = (DateTime?)null,
                Status = "In Progress",
                Comment = "Comedy of manners",
                ClientID = 3
            }
    );
        }
    }
}
