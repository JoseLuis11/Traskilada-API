using System.Collections.Generic;

namespace TraskiladaWebAPI.Models
{
    public class WorkPlace : BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<User> Employees { get; set; }
    }
}