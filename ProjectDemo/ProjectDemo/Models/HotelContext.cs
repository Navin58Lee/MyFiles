using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectDemo.Models
{
    public class HotelContext : DbContext
    {
        public HotelContext() : base("name=HotelContext")
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
    }
}