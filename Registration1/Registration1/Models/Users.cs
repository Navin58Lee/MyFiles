using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registration1.Models
{
    public class Users
    {
        [Key]
        [Required]
        [Display(Name="Id")]
        public int Id { get; set; }
        [Display(Name="Name")]
        public string Name { get; set; }
        [Display(Name="Mobile")]
        public string Mobile { get; set; }
    }
}