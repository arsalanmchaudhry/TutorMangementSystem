using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TutorMangementSystem.Models
{
    public class MemberID
    {
        public int Id { get; set; }

        [Display(Name = "Account Balance")] public decimal Balance { get; set; }

        [Display(Name = "Issued")] public DateTime CardIssued { get; set; }

        [Display(Name = "Resevered Tutors")] public virtual IEnumerable<Reserve> Reserves { get; set; }
    }

}
