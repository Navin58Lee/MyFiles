using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    class Room
    {
        [Key]
        public int RoomId { get; set; }

        public int RID { get; set; }

        public string BlockName { get; set; }

        public string FloorNumber { get; set; }
    }
}
