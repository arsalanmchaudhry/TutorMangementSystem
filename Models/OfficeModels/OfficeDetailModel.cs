using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorMangementSystem.Models.OfficeModels
{
    public class OfficeDetailModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string OfficeName { get; set; }
        public string OfficeOpenDate { get; set; }
        public string Telephone { get; set; }
        public bool IsOpen { get; set; }
        public string Description { get; set; }
        public int NumberOfStudents { get; set; }
        public int NumberOfTutors { get; set; }
        public string OfficeImg { get; set; }
        public IEnumerable<string> HoursOpen { get; set; }
    }
}
