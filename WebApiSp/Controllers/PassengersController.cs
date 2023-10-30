using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiSp.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebApiSp.Controllers
{ 
    [ApiController]
    [Route("api/[controller]")]
   
    public class PassengersController : ControllerBase
    {
        private readonly MyDbContext _context;

        public PassengersController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passengers>>> GetPassengers()
        {
            return await _context.Passengers.ToListAsync();
        }
       
        [HttpPost]
        public async Task<ActionResult<Passengers>> CreatePassengers(Passengers Passengers)
        {
            _context.Passengers.Add(Passengers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPassengers", new { id = Passengers.PassengerID }, Passengers);
        }
    }
}
