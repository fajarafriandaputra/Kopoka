using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrialDev.Models
{
    public class JobVacancy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobId { get; set; }

        [Required]
        [Column(TypeName ="varchar(50)")]
        [Display(Name ="Job Title")]
        public string JobTitle { get; set; }
        
        [Display(Name = "Vacancy Name")]
        [Column(TypeName = "varchar(50)")]
        public string VacancyName { get; set; }
        
        [Required]
        public DateTime PeriodeStart { get; set; }
        [Required]
        public DateTime PeriodeEnd { get; set; }
        public int Slots { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
