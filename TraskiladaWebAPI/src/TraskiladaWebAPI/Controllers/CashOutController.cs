using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TraskiladaWebAPI.Models;
using TraskiladaWebAPI.Context;

namespace TraskiladaWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CashOutController : Controller
    {

        private readonly TraskiladaContext _context;

        public CashOutController(TraskiladaContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<CashOut> Get()
        {
            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public CashOut Get(int id)
        {
            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]CashOut value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]CashOut value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}