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
   
    public class BookingsController : Controller
    {
       private readonly MyDbContext _contextab;
        public BookingsController(MyDbContext contextab)
        {
            _contextab = contextab;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bookings>>> GetBookings()
        {
            return await _contextab.Bookings.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Bookings>> CreateBookings(Bookings Bookings)
        {
            _contextab.Bookings.Add(Bookings);
            await _contextab.SaveChangesAsync();

            return CreatedAtAction("GetBookings", new { id = Bookings.BookingID }, Bookings);
        }
    }
}
