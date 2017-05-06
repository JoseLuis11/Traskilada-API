namespace TraskiladaWebAPI.Models
{
    public class Employee 
    {
        public int userId { get; set; }
        //public ICollection<WorkPlace> workplaces { get; set; }
        //public ICollection<Service> services { get; set; }
        //public ICollection<Appointment> appointments { get; set; }
        public bool isOwner { get; set; }
    }
}