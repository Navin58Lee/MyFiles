using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CampusMindTrackAllocationNew.Models
{
    public class Both
    {
        [Key]
        public int id { get; set; }
        public List<User> users { get; set; }
        public List<Track> tracks { get; set; }
    }
  

}