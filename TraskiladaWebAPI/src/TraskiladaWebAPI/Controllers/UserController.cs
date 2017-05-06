using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TraskiladaWebAPI.Models;
using TraskiladaWebAPI.Context;
using System.Threading;

namespace TraskiladaWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {

        private readonly TraskiladaContext _context;

        public UserController(TraskiladaContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _context.UserRepository.GetAllAsync(CancellationToken.None);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await _context.UserRepository.FindAsync(CancellationToken.None);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]User value)
        {
            _context.UserRepository.AddAsync(value, CancellationToken.None);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]User value)
        {
            _context.UserRepository.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.UserRepository.RemoveById(id);
        }

    }
}