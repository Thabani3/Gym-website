using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthAW.Models
{
    public class Items
    {
        [Key]
        public int ItemId { get; set; }
        public string Itemame { get; set; }
    }
}