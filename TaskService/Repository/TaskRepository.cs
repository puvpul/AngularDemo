using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskService.Repository;
using Twilio;

namespace TaskService.Models
{
    public class TaskRepository : ITaskRepository
    {
        TaskContext db;

        public TaskRepository(TaskContext ctx)
        {
            db = ctx;
        }
        public IQueryable<ServiceJob> GetJobs()
        {
            return db.ServiceJobs;
        }
        
        public IQueryable<ServiceJob> GetJobsByTechnician(int technicianId)
        {
            return db.ServiceJobs.Where(p => p.TechnicianId == technicianId);
        }
    }
}
