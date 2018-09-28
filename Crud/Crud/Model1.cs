namespace Crud
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Table_2> Table_2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_2>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Table_2>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Table_2>()
                .Property(e => e.Address)
                .IsUnicode(false);
        }
    }
}
