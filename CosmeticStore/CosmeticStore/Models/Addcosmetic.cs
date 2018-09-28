using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CosmeticStore.Models
{
    public class Addcosmetic
    {
        [Key]
        public int cid { get; set; }
        public string CosmeticName { get; set; }
        public string Company { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }
    }
}           