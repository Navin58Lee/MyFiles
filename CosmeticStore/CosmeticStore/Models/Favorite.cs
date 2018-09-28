using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CosmeticStore.Models
{
    public class Favorite
    {
        [Key]
        public int fid { get; set; }
        [ForeignKey("Addcosmetic")]
        public int cid { get; set; }
        public Addcosmetic Addcosmetic { get; set; }
        [ForeignKey("Adduser")]
        public int uid { get; set; }
        public Adduser Adduser { get; set; }
    }
}