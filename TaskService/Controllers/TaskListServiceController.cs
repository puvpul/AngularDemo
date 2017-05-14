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
        //TaskContext ctx = new TaskContext();
        //TaskRepository _db = new TaskRepository(ctx);

        [HttpGet]
        public List<ServiceJob> GetAllJobs()
        {
            List<ServiceJob> svj = null;
            return svj;
        }


        //[HttpPost]
        //public void UpdateServiceJob(ServiceJob newJob)
        //{
        //    _db.Update(newJob);
        //}
    }



}
