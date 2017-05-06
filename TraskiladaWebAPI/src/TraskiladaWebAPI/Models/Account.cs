namespace TraskiladaWebAPI.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string password {get ; set; }
        public string userId {get; set; }
        public LoginType LoginType {get; set;}  
    }
}