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
        //private ServiceTaskEntities _db = new ServiceTaskEntities();

        //public List<ServiceJob> GetAll()
        //{
        //    //SendSms();
        //    return _db.ServiceJobs.ToList();

        //}

        //public void Update(ServiceJob updServiceJob)
        //{
        //    ServiceJob curentJob = this._db.ServiceJobs.FirstOrDefault(
        //        r => r.JobID == updServiceJob.JobID);
        //    curentJob.Status = updServiceJob.Status;
        //    curentJob.Comment = updServiceJob.Status;
        //    this.Save();
        //    if (curentJob.Comment != string.Empty)
        //        SendSms();
        //}

        //private void SendSms()
        //{
        //    string AccountSid = "ACaabca65ff12e9985848838bb2254064b";
        //    string AuthToken = "{{ 181971c24690538268c1f10f90e37fc4 }}";
        //    var twilio = new TwilioRestClient(AccountSid, AuthToken);


        //    var message = twilio.SendMessage("+61434534732", "+", "Jenny knows this <3", new string[] { "http://www.example.com/hearts.png" });

        //    //Console.WriteLine(message.Sid);

        //}

        //public void Save()
        //{
        //    _db.SaveChanges();
        //}
        public IQueryable<ServiceJob> GetJobs()
        {
            throw new NotImplementedException();
        }

        public IQueryable<ServiceJob> GetJobsByTechnician(int technicianId)
        {
            throw new NotImplementedException();
        }
    }
}
