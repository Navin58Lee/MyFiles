using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi
{
    public class Customers
    {
        [Required(ErrorMessage = "id is required")]
        public int Customer_ID { get; set; }
        public string CustomerName { get; set; }

    }
}