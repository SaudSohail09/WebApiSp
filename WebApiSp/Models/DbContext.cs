using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace WebApiSp.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Passengers> Passengers { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        public DbSet<Flights> Flights { get; set; }
       

    }
}

