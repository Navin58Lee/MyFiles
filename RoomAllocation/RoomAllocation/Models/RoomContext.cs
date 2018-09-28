using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RoomAllocation.Models
{
    public class RoomContext : DbContext
    {
        public RoomContext() : base("name=RoomContext")
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Allocate> Allocate { get; set; }
        public object Allocates { get; internal set; }
    }
}