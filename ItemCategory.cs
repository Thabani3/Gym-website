using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthAW.Models
{
    public class ItemCategory
    {
        [Key]
        public int ItemCategoryId { get; set; }
        public string ItemCategoryName { get; set; }
    }
}