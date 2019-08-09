using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TutorMangementSystem.Models
{

    public class Wishlist
    {
        public int Id { get; set; }
        public virtual Tutor Tutor { get; set; }
        public virtual MemberID MemberID { get; set; }
    }
}
