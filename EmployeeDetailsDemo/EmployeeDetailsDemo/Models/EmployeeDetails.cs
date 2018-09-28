using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeDetailsDemo.Models
{
    public class EmployeeDetails
    {
        [Required(ErrorMessage = "id is required")]
        public int Employee_ID { get; set; }
        public string EmployeeName { get; set; }
    }
}