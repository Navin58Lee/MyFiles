using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyRoom.Entities
{
    public class CityDetails
    {
            [Key]
            public int cityId { get; set; }
            public string cityName { get; set; }
    }
}
