using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    class User
    {
        [Key]
        public int Uid { get; set; }
        public string MID { get; set; }

        public string Name { get; set; }

        public string TrackName { get; set; }
    }
}
