using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskService.Models
{
    public class TaskContext:DbContext
    {
        public TaskContext():base("TaskConnection")
        {
            
        }

        public DbSet<Technician> Technicians { get; set; }
        public DbSet<ServiceJob> ServiceJobs { get; set; } 
    }
}