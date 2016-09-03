using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWorld.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TheWorld.Controllers.Api
{
    public class TripController : Controller
    {
        [HttpGet("api/trips")]
        public IActionResult Get()
        {
            if (true) return BadRequest("Bad things happened");

            return Ok(new Trip() { Name = "My Trip" });
        }
    }
}
