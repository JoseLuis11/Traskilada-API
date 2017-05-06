using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TraskiladaWebAPI.Models
{
    public class User : BaseModel
    {
        public int Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int EmployeeDetailId { get; set; }
        public EmployeeDetail EmployeeDetail { get; set; }

        [InverseProperty("Employee")]
        public ICollection<Appointment> AttendedAppointments { get; set; }
        [InverseProperty("Client")]
        public ICollection<Appointment> OrderedAppointments { get; set; }
    }
}