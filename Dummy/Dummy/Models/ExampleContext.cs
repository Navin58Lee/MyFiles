using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dummy.Models
{
    public class ExampleContext : DbContext
    {
        public ExampleContext(): base("name=ExampleContext")
        {
        }
        public DbSet<Example> example { get; set; }
    }
}