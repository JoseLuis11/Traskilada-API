using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TraskiladaWebAPI.Context;
using TraskiladaWebAPI.Dtos;
using TraskiladaWebAPI.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TraskiladaWebAPI.Controllers
{

    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly TraskiladaContext _context;

        public AccountController(TraskiladaContext context)
        {
            _context = context;
        }

        //TODO: Create DTO for login information request
        [HttpPost]
        public async Task<User> Login([FromBody] LoginDto login)
        {
            //TODO: Map from requestDTO to accountModel;
            var account = new Account { Email = login.Email, Password = login.Password };
            var result = await _context.AccountRepository.ValidateCredentials(account);
            return result.User;
        }
    }
}
