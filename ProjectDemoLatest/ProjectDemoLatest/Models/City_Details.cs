using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectDemoLatest.Models
{
    public class City_Details
    {
        [Key]
        public int City_Id { get; set; }
        public string City_Name { get; set; }
    }
}