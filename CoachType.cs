using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HealthAW.Models
{
    public class CoachType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CoachTypeId { get; set; }
        [Display(Name = "Coach Type")]
        public string CoachTypeName { get; set; }
        public virtual CoachType coachType { get; set; }
    }
}