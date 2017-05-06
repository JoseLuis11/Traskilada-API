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
    public class WorkPlaceController : Controller
    {

        private readonly TraskiladaContext _context;

        public WorkPlaceController(TraskiladaContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<WorkPlace>> Get()
        {
            return await _context.WorkPlaceRepository.GetAllAsync(CancellationToken.None);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<WorkPlace> Get(int id)
        {
            return await _context.WorkPlaceRepository.FindAsync(id, CancellationToken.None);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]WorkPlace value)
        {
            _context.WorkPlaceRepository.AddAsync(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]WorkPlace value)
        {
            _context.WorkPlaceRepository.Update(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.WorkPlaceRepository.RemoveById(id);
        }

    }
}