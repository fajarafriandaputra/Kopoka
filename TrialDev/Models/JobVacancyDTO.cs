using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrialDev.Models
{
    public class JobVacancyDTO
    {
        
        public int JobId { get; set; }
        [Required]
        public string JobTitle { get; set; }
        public string VacancyName { get; set; }
        [Required]
        public string Period { get; set; }
        public int? Slots { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
