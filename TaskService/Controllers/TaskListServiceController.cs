using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using TaskService.Models;
using TaskService.Repository;

namespace TaskService.Controllers
{
    [EnableCors("*","*","*")]
    public class TaskListServiceController : ApiController
    {
        ITaskRepository _taskRepository;

        public TaskListServiceController(ITaskRepository taskRepo)
        {
            _taskRepository = taskRepo;
        }
        [HttpGet]
        public List<ServiceJob> GetAllJobs()
        {
           
            return _taskRepository.GetJobs().ToList();
        }


        //[HttpPost]
        //public void UpdateServiceJob(ServiceJob newJob)
        //{
        //    _db.Update(newJob);
        //}
    }



}
