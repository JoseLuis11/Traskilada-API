using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TraskiladaWebAPI.Controllers
{
    public enum LoginType
    {
        Client = 1,
        Employee = 2
    }

    public class Account
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public LoginType LoginType { get; set; }
        public User User { get; set; }

    }

    public class User
    {
        public int UserID { get; set; }
    }

    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        [HttpPost]
        public User Login(string username, string password)
        {
            //TODO: Validate user credentials
            var result = new Account();

            return result.User;
        }
    }
}
