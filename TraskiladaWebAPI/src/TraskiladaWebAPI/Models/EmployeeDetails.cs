namespace TraskiladaWebAPI.Models
{
    public class EmployeeDetails : BaseModel
    {
        public int UserId { get; set; }
        //public ICollection<WorkPlace> workplaces { get; set; }
        //public ICollection<Service> services { get; set; }
        //public ICollection<Appointment> appointments { get; set; }
        public bool IsOwner { get; set; }
        public User User {get; set;}
    }
}