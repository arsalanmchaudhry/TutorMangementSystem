using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TutorMangementSystem.Models
{
    public class Register
    {
        public int Id { get; set; }

        [Required] public Tutor Tutor { get; set; }

        [Required] public MemberID MemberId { get; set; }

        [Required] public DateTime ReservedSince { get; set; }

        public DateTime? AvailiableSince { get; set; }
    }
}
