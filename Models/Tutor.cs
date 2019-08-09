using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TutorMangementSystem.Models
{
    public class Tutor
    {
        public int Id { get; set; }
        public string TutorName { get; set; }
        [Required] public string Subject { get; set; }

        [Required] public ReserveOption ReserveOption { get; set; }

        [Required]
        [Display(Name = "Cost of Service")]
        public decimal Cost { get; set; }
        public string TutorIMG { get; set; }
        public string available { get; set; }
        public virtual Office OfficeLocation { get; set; }
    }
}
