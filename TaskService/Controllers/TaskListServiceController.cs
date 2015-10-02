using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using TaskService.Models;

namespace TaskService.Controllers
{
    [EnableCors("*","*","*")]
    public class TaskListServiceController : ApiController
    {
        ServiceTaskRepository _db = new ServiceTaskRepository();

        [HttpGet]
        public List<ServiceJob> GetAllJobs()
        {
            return _db.GetAll();
        }


        [HttpPost]
        public void UpdateServiceJob(ServiceJob newJob)
        {
            _db.Update(newJob);
        }
    }



}
