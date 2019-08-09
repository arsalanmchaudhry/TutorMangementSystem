using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TutorMangementSystem.Models
{
    public class Office
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Office: ")]
        [StringLength(30, ErrorMessage = "Limit office name to 30 characters.")]
        public string Name { get; set; }

        [Required] public string Address { get; set; }

        [Required] public string Telephone { get; set; }

        public string Description { get; set; }
        public DateTime OpenDate { get; set; }

        public virtual IEnumerable<Student> Students { get; set; }
        public virtual IEnumerable<Tutor> Tutors { get; set; }

        public string OfficeIMG { get; set; }
    }
}
