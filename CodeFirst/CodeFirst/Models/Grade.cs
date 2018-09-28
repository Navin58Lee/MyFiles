using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public string GradeName  { get; set; }
    }
}