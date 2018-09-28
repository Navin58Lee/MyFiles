using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectDemoLatest.Models
{
    public class Hotel_Details
    {
        [Key]
        public int Hot_Id { get; set; }
        public string Hot_Name { get; set; }
        public string Hot_Add { get; set; }
        public int Total_Room { get; set; }
        public int Hotel_Rating { get; set; }
    }
}