namespace EventCreation
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CrudTable")]
    public partial class CrudTable
    {
        [Key]
        [StringLength(50)]
        public string Title { get; set; }

        [Column("Date and Time")]
        [StringLength(50)]
        public string Date_and_Time { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Location { get; set; }
    }
}
