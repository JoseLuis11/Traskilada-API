namespace TraskiladaWebAPI.Models
{
    public class User : BaseModel 
    {
        public int Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber {get ; set; }
    }
}