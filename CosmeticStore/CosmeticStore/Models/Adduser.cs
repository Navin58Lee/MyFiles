using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CosmeticStore.Models
{
    public class Adduser
    { 
        [Key]
        public int uid { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        
    }
}