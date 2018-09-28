using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=StudentContext")
        {

        }
        public DbSet<Student> Stduents { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}