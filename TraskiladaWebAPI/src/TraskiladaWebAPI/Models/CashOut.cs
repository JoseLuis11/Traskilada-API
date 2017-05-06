namespace TraskiladaWebAPI.Models
{
    public class CashOut : BaseModel
    {
        public double Amount { get; set; }
        public DateTime DateTime {get; set;} 
        public string UserId {get; set;}
    }
}