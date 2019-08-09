using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TutorMangementSystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Please enter student name...")]
        [DisplayName("Student Name")]
        public string StudentName { get; set; }
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Grade Level")]
        public string SchoolGradeLevel { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Major { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string College { get; set; }
        public virtual MemberID MemberID { get; set; }
        public virtual Office Office { get; set; }
    }
}
