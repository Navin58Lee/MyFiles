namespace Mvc_crud
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Crud_Model : DbContext
    {
        public Crud_Model()
            : base("name=Crud_Model")
        {
        }   


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
