using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskService.Models
{
    public class Technician
    {
        public int TechnicianID { get; set; }
        public string Name { get; set; }

        
        public virtual ICollection<ServiceJob> ServiceJobs { get; set; }
    }
}