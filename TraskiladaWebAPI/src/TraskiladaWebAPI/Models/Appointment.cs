using System;
using System.Collections.Generic;

namespace TraskiladaWebAPI.Models
{
    public class Appointment : BaseModel
    {
        public DateTime DateTime {get; set;}
        public int EmployeeId {get; set;}
        public int ClientId {get; set;}
        public ICollection<Service> Services {get; set;} 
    }
}