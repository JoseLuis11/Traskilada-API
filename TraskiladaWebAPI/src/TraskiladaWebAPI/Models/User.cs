using System.Collections.Generic;

namespace TraskiladaWebAPI.Models
{
    public class User : BaseModel
    {
        public int Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int EmployeeDetailId { get; set; }
        public EmployeeDetail EmployeeDetail { get; set; }
    }
}