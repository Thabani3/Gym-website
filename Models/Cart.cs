using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthAW.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public string Products { get; set; }
        public string PaymentPrice { get; set; }
        public string Items { get; set; }
    }
}