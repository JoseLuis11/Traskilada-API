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
    public class ReviewController : Controller
    {

        private readonly TraskiladaContext _context;

        public ReviewController(TraskiladaContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Review>> Get()
        {
            return await _context.ReviewRepository.GetAllAsync(CancellationToken.None);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<Review>Get(int id)
        {
            return await _context.ReviewRepository.FindAsync(CancellationToken.None);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Review value)
        {
            _context.ReviewRepository.AddAsync(value, CancellationToken.None);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Review value)
        {
            _context.ReviewRepository.AddAsync(value,CancellationToken.None);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.ReviewRepository.RemoveById(id);
        }

    }
}