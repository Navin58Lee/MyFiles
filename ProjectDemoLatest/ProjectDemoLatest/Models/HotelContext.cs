using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectDemoLatest.Models
{
    public class HotelContext: DbContext
    {
        public HotelContext() : base("name=HotelContext")
        {

        }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<City_Details> City_Details { get; set; }
        public DbSet<Hotel_City_Mapping> Hotel_City_Mapping { get; set; }
        public DbSet<Hotel_Details> Hotel_Details { get; set; }
        public DbSet<Room_Booking_Details> Room_Booking_Details { get; set; }
        public DbSet<Room_Details> Room { get; set; }
        public IQueryable<Dummy> Dummy { get; internal set; }
    }
}