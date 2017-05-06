using System.Collections.Generic;

namespace TraskiladaWebAPI.Models
{
    public class EmployeeDetails : BaseModel
    {
        public int UserId { get; set; }
        public ICollection<WorkPlace> Workplaces { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public bool IsOwner { get; set; }
        public User User { get; set; }
    }
}