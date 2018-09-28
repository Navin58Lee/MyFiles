using BookMyRoom.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyRoom.DataAccessLayer.DbContext
{
    public class RoomDetailsDBContext: System.Data.Entity.DbContext
    {
        public RoomDetailsDBContext() : base("name=RoomDetailsDBContext")
        {

        }
        public DbSet<Booking> booking { get; set; }
        public DbSet<CityDetails> cityDetails { get; set; }
        public DbSet<HotelCityMapping> hotelCityMapping { get; set; }
        public DbSet<HotelDetails> hotelDetails { get; set; }
        public DbSet<RoomBookingDetails> roomBookingDetails { get; set; }
        public DbSet<RoomDetailsSearch> roomDetails { get; set; }
        public IQueryable<SearchHotel> searchHotel { get; internal set; }

    }
}
