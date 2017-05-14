using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskService.Models
{
    public class ServiceJob
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public Nullable<int> TechnicianID { get; set; }
        public Nullable<int> ClientID { get; set; }

        //public virtual Technician Technician { get; set; }
    }
}