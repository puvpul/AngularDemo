using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskService.Models;

namespace TaskService.Repository
{
    public interface ITaskRepository
    {
        IQueryable<ServiceJob> GetJobs();
        IQueryable<ServiceJob> GetJobsByTechnician(int technicianId);  
    }
}
