using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TraskiladaWebAPI.Models;

namespace TraskiladaWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AppointmentController : Controller
    {

        // GET api/values
        [HttpGet]
        public IEnumerable<Appointment> Get()
        {
            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Appointment Get(int id)
        {
            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Appointment value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Appointment value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}