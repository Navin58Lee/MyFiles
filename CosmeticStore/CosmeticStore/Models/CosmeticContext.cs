using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CosmeticStore.Models
{
    public class CosmeticContext : DbContext
    {
      public CosmeticContext() : base("name=CosmeticContext")
        {

        }
        public DbSet<Addcosmetic> Addcosmetic { get; set; }
        public DbSet<Adduser> Adduser { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
}
}