namespace TraskiladaWebAPI.Models
{
    public class Review :BaseModel
    {
        public double Rating { get; set; }
        public string Message {get; set;}
        public int UserId {get; set;}
    }
}