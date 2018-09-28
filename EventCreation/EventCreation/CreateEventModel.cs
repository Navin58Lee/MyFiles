namespace EventCreation
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CreateEventModel : DbContext
    {
        public CreateEventModel()
            : base("name=CreateEventModel")
        {
        }

        public virtual DbSet<CrudTable> CrudTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CrudTable>()
                .Property(e => e.Title)
                .IsFixedLength();

            modelBuilder.Entity<CrudTable>()
                .Property(e => e.Date_and_Time)
                .IsFixedLength();

            modelBuilder.Entity<CrudTable>()
                .Property(e => e.Duration)
                .IsFixedLength();

            modelBuilder.Entity<CrudTable>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<CrudTable>()
                .Property(e => e.Location)
                .IsFixedLength();
        }
    }
}
