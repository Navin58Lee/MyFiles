using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookingHistory.Models
{
    public class Hotel_City_Mapping
    {
        [Key]
        public int Mapping_Id { get; set; }
        [ForeignKey("Hotel_Details")]
        public int Hot_Id { get; set; }
        public Hotel_Details Hotel_Details { get; set; }
        [ForeignKey("City_Details")]
        public int City_Id { get; set; }
        public City_Details City_Details { get; set; }
    }
}