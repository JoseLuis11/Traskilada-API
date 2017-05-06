using System;
using System.Collections.Generic;

namespace TraskiladaWebAPI.Models
{
    public class Appointment : BaseModel
    {
        public DateTime DateTime { get; set; }
        public ICollection<Service> Services { get; set; }
        public int EmployeeUserId { get; set; }
        public int ClientUserId { get; set; }

        public User Employee { get; set; }
        public User Client { get; set; }
    }
}