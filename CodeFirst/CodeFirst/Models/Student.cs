using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string  Student_Name { get; set; }
        public string Address { get; set; }
        
        public int GradeId { get; set; }
        [ForeignKey("GradeId")]
        public Grade Grade { get; set; }
    }
}