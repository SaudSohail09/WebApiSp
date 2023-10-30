using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSp.Models;

namespace WebApiSp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
  
    public class FlightsController : Controller
    {
        private readonly MyDbContext _contextabc;
        public FlightsController(MyDbContext contextabc)
        {
            _contextabc = contextabc;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Flights>>> GetFlights()
        {
            return await _contextabc.Flights.ToListAsync();
        }

    }
}
