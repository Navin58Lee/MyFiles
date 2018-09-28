using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dummy.Models
{
    public class Example
    {
        [Key]
        public int eid { get; set; }
        public string name { get; set; }
        //public DateTime checkIn { get; set; }
        //public DateTime checkOut { get; set; }
        public string location { get; set; }
    }
}