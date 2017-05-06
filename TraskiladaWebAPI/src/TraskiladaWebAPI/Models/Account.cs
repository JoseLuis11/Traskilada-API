namespace TraskiladaWebAPI.Models
{
    public class Account : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public LoginType LoginType { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}