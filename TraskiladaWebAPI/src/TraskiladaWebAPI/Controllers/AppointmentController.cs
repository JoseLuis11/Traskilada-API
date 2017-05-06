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
    public class AppointmentController : Controller
    {

        private readonly TraskiladaContext _context;

        public AppointmentController(TraskiladaContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Appointment>> Get()
        {
            return await _context.AppointmentRespository.GetAllAsync(CancellationToken.None);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<Appointment> Get(int id)
        {
            return await _context.AppointmentRespository.FindAsync(id, CancellationToken.None);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Appointment value)
        {
            _context.AppointmentRespository.AddAsync(value, CancellationToken.None);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Appointment value)
        {
            _context.AppointmentRespository.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.AppointmentRespository.RemoveById(id);
        }

    }
}