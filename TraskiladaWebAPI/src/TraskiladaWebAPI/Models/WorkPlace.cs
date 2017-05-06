namespace TraskiladaWebAPI.Models
{
    public class WorkPlace : BaseModel
    {
        public string Name { get; set; }
        public string Address {get; set;}
        public ICollection<WorkPlaceEmployee> Employees {get; set;}
    }
}