using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorMangementSystem.Models;

namespace TutorMangementSystem
{
    public interface IOffice
    {
        IEnumerable<Office> GetAll();
        IEnumerable<Student> GetStudents(int officeId);
        IEnumerable<Tutor> GetTutors(int officeId);
        Office Get(int officeId);
        void Add(Office newOffice);
        IEnumerable<string> GetOfficeHours(int officeId);
        bool IsOfficeOpen(int officeId);
        int GetTutorCount(int officeId);
        int GetStudentCount(int officeId);
       
    }
}
