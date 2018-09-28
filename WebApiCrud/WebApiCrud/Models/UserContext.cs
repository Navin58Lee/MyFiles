using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApiCrud.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=UserContext")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}