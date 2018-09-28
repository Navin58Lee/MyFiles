using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeDetailsDemo.Models
{
    public class Department
    {
        [Required(ErrorMessage = "id is required")]
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<EmployeeDetails> EmployeeDetails{ get; set; }
    }
}