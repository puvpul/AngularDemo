using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TaskService.Models
{
    public class TaskContext:DbContext
    {
        public TaskContext():base("TaskConnection")
        {
            //Database.SetInitializer<TaskContext>(new DropCreateDatabaseAlways<TaskContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TaskContext, Migrations.Configuration>("TaskConnection"));
        }

        public DbSet<Technician> Technicians { get; set; }
        public DbSet<ServiceJob> ServiceJobs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}