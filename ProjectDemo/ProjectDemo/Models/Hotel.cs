using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectDemo.Models
{
    public class Hotel
    {
        [Key]
        public int Hotel_Id { get; set; }

        public string Hotel_Name { get; set; }
        public string City { get; set; }
        public string Room_Type { get; set; }
        public int Price { get; set; }
        public DateTime Check_In { get; set; }
        public DateTime Check_Out { get; set; }
    }
}