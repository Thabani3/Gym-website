using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthAW.Models
{
    public class Coach
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CoachId { get; set; }
        [Display(Name = "Coach Names")]
        public string CoachTypeNames { get; set; }
        [Display(Name = "Coach Name")]
        public int CoachExperience { get; set; }
        public List<CoachType> coachTypes { get; set; }
    }
}