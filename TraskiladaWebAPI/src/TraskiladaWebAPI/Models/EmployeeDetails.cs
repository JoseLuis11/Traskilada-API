using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TraskiladaWebAPI.Models
{
    public class EmployeeDetail : BaseModel
    {
        public int UserId { get; set; }
        public ICollection<WorkPlace> OwnedWorkPlaces { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public int WorkPlaceId { get; set; }
        public WorkPlace WorkPlace { get; set; }

        [NotMapped]
        public bool IsOwner => OwnedWorkPlaces.Count > 0;

    }
}