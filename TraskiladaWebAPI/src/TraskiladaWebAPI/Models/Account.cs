namespace TraskiladaWebAPI.Models
{
    public class Account : BaseModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password {get ; set; }
        public User User {get; set; }
        public LoginType LoginType {get; set;}  
    }
}