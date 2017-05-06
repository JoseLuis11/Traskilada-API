namespace TraskiladaWebAPI.Models
{
    public class WorkPlaceEmployee : BaseModel
    {
        public int UserId { get; set; }
        public int WorkplaceId {get; set;}
    }
}