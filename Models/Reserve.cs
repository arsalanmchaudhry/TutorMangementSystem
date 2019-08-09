using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TutorMangementSystem.Models
{
    public class Reserve
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tutor")]
        public Tutor Tutor { get; set; }

        [Display(Name = "Member ID Card")] public MemberID MemberID { get; set; }

        [Display(Name = "Reserved Since")] public DateTime ReservedDate { get; set; }

       
    }
}
