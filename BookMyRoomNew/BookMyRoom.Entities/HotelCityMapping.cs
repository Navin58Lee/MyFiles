﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyRoom.Entities
{
    public class HotelCityMapping
    {
        [Key]
        public int mappingId { get; set; }
        [ForeignKey("hotelDetails")]
        public int hotelId { get; set; }
        public HotelDetails hotelDetails { get; set; }
        [ForeignKey("cityDetails")]
        public int cityId { get; set; }
        public CityDetails cityDetails { get; set; }
    }
}
