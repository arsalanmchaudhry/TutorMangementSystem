using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorMangementSystem.Models.ReserveModels
{
    public class ReserveModel
    {
        public string MemberId { get; set; }
        public string Tutor { get; set; }
        public int TutorId { get; set; }
        public string IMG { get; set; }
        public int WishlistCount { get; set; }
        public bool IsReserved { get; set; }
    }
}
