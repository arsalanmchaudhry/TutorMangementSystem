using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorMangementSystem.Models.BrowseTutors
{
    public class TutorIndexModel
    {
        public int Id { get; set; }
        public string TutorName { get; set; }
        public string Subject { get; set; }
        public decimal Cost { get; set; }
        public string TutorIMG { get; set; }
        // public virtual Office OfficeLocation { get; set; }
    }
}
