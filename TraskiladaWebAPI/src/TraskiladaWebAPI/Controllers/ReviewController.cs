﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TraskiladaWebAPI.Models;

namespace TraskiladaWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ReviewController : Controller
    {

        // GET api/values
        [HttpGet]
        public IEnumerable<Review> Get()
        {
            return null;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Review Get(int id)
        {
            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Review value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Review value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}