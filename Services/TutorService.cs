using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorMangementSystem.Models;

namespace TutorMangementSystem.Services
{
    public class TutorService : ITutor
    {
        private StudentContext _context;

        public TutorService(StudentContext context)
        {
            _context = context;
        }

        public void AddTutor(Tutor newTutor)
        {
            _context.Add(newTutor);
            _context.SaveChanges();
        }

        public IEnumerable<Tutor> GetAll()
        {
            return _context.Tutors
                .Include(tutor => tutor.ReserveOption)
                .Include(tutor => tutor.OfficeLocation);
        }

        //Return first instance of the case
        public Tutor GetById(int id)
        {
            return GetAll()
                .FirstOrDefault(tutor => tutor.Id == id);
        }

        public string GetName(int id)
        {
            return _context.Tutors
                .FirstOrDefault(t => t.Id == id).TutorName;
        }

        public Office GetOfficeLocation(int id)
        {
            return GetById(id).OfficeLocation;
        }

        public string GetSubject(int id)
        {
            return _context.Tutors
                .FirstOrDefault(t => t.Id == id).Subject;
        }
    }
}
