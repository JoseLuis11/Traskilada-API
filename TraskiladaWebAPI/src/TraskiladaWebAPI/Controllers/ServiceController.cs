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
    public class ServiceController : Controller
    {

        private readonly TraskiladaContext _context;

        public ServiceController(TraskiladaContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Service>> Get()
        {
            return await _context.ServiceRepository.GetAllAsync(CancellationToken.None);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<Service> Get(int id)
        {
            return await _context.ServiceRepository.FindAsync(id, CancellationToken.None);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Service value)
        {
            _context.ServiceRepository.AddAsync(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Service value)
        {
            _context.ServiceRepository.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.ServiceRepository.RemoveById(id);
        }

    }
}