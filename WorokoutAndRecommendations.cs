using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthAW.Models
{
    public class WorokoutAndRecommendations
    {
        [Key]
        public int WRecId { get; set; }
        public string WRecName { get; set; }
   
    }
}