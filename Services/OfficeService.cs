using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorMangementSystem.Models;
using Microsoft.EntityFrameworkCore;



namespace TutorMangementSystem.Services
{
    public class OfficeService : IOffice
    {
        private StudentContext _context;

        public OfficeService(StudentContext context)
        {
            _context = context;
        }

        public void Add(Office newOffice)
        {
            _context.Add(newOffice);
            _context.SaveChanges();
        }

        public Office Get(int officeId)
        {
            return _context.Offices
                 .Include(b => b.Students)
                 .Include(b => b.Tutors)
                 .FirstOrDefault(p => p.Id == officeId);
        }

        public IEnumerable<Office> GetAll()
        {
            return _context.Offices.Include(a => a.Students).Include(a => a.Tutors);
        }

        public IEnumerable<string> GetOfficeHours(int officeId)
        {
            var hours = _context.OfficeHours.Where(a => a.Office.Id == officeId);

            var displayHours =
                DataService.ReadbleHours(hours);

            return displayHours;
        }

        public int GetStudentCount(int officeId)
        {
            return Get(officeId).Students.Count();
        }

        public IEnumerable<Student> GetStudents(int officeId)
        {
            return _context.Offices.Include(x => x.Students).First(y => y.Id == officeId).Students;
        }

        public int GetTutorCount(int officeId)
        {
            return Get(officeId).Tutors.Count();
        }

        public IEnumerable<Tutor> GetTutors(int officeId)
        {
            return _context.Offices.Include(x => x.Tutors)
                .First(y => y.Id == officeId).Tutors;
        }

        public bool IsOfficeOpen(int officeId)
        {
            return true;
        }
    }
}
