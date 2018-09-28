using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectDemoLatest.Models
{
    public class Dummy
    {
        [Key]
        public int Dummy_Id { get; set; }
        public string Hot_Name { get; set; }
        public string Hot_Add { get; set; }
        public string Room_Type { get; set; }
        public string City_Name { get; set; }
        public string CheckIn_Date { get; set; }
        public string CheckOut_Date { get; set; }
        public string Room_Id { get; set; }

    }
}