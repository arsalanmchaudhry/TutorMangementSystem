using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorMangementSystem.Models;

namespace TutorMangementSystem.Services
{
    public class ReserveService : IReserve
    {
        private StudentContext _context;

        public ReserveService(StudentContext context)
        {
            _context = context;
        }

        public void CreateReserve(Reserve newReserve)
        {
            _context.Add(newReserve);
            _context.SaveChanges();
        }

        public IEnumerable<Reserve> GetAll()
        {
            return _context.Reserves; //return all instances of Reserves
        }

        public Reserve GetByReserveId(int reserveId)
        {
            return GetAll().FirstOrDefault(reserve => reserve.Id == reserveId);
        }

        public IEnumerable<Register> GetRegisters(int id)
        {
            return _context.Registers
                .Include(r => r.Tutor)
                .Include(r => r.MemberId)
                .Where(r => r.Tutor.Id == id);
        }

        //Method to mark tutor as reserved
        public void ReservedTutor(int tutorId, int memberCardId)
        {
            //check if tutor is already reserved
            if (IsReserved(tutorId))
            {
                return;
            }

            //Grab tutor id
            var tutor = _context.Tutors
                .Include(a => a.ReserveOption)
                .First(a => a.Id == tutorId);

            _context.Update(tutor);

            //mark tutor as reserved
            tutor.ReserveOption = _context.ReserveOptions
                .FirstOrDefault(r => r.Name == "Reserved");


            //Assign tutor to student member id card
            var now = DateTime.Now;

            var memberID = _context.MemberIDs //grab member card
                .Include(c => c.Reserves)
                .FirstOrDefault(a => a.Id == memberCardId);


            //Create new reserve
            var reserve = new Reserve
            {
                Tutor = tutor,
                MemberID = memberID,
                ReservedDate = now,
                
            };

            _context.Add(reserve); //add to table in DB

            var register = new Register
            {
                ReservedSince = now,
                Tutor = tutor,
                MemberId = memberID
            };

            _context.Add(register);
            _context.SaveChanges();
        }

        public bool IsReserved(int id)
        {
            var isReserved = _context.Reserves.Any(a => a.Tutor.Id == id);

            return isReserved;
        }

        //Method to mark tutor as available
        public void AvailableTutor(int tutorId)
        {
            var now = DateTime.Now;

            var tutor = _context.Tutors
                .First(a => a.Id == tutorId);

            _context.Update(tutor);

            // remove any existing reserves on the tutor as it will become available
            var reserved = _context.Reserves
                .Include(c => c.Tutor)
                .Include(c => c.MemberID)
                .FirstOrDefault(a => a.Tutor.Id == tutorId);
            if (reserved != null)
            {
                _context.Remove(reserved);
            }

            // close any existing registers (reserve history)
            var register = _context.Registers
                .Include(h => h.Tutor)
                .Include(h => h.MemberId)
                .FirstOrDefault(h =>
                    h.Tutor.Id == tutorId
                    && h.AvailiableSince == null);
            if (register != null)
            {
                _context.Update(register);
                register.AvailiableSince = now;
            }

            // look for any wishlists
            var wishlists = _context.Wishlists
                .Include(a => a.Tutor)
                .Include(a => a.MemberID)
                .Where(a => a.Tutor.Id == tutorId);

            // if there are current wishlists, reserve out the tutor to the earliest student
            if (wishlists.Any())
            {
                ReserveToFirstStudentWishlist(tutorId, wishlists);

                return;
            }

            // else, set tutor status to available
            tutor.ReserveOption = _context.ReserveOptions.FirstOrDefault(a => a.Name == "Available");

            _context.SaveChanges();
        }

        private void ReserveToFirstStudentWishlist(int tutorId, IQueryable<Wishlist> wishlists)
        {
            var firstWishlistStudent = wishlists
                .FirstOrDefault(w => w.Tutor.Id == tutorId);

            var memberId = firstWishlistStudent.MemberID;
            _context.Remove(firstWishlistStudent);
            _context.SaveChanges();
            ReservedTutor(tutorId, memberId.Id);
        }


        public Reserve GetRecentReserve(int id)
        {
            return _context.Reserves
                .Where(r => r.Tutor.Id == id)
                .OrderByDescending(c => c.ReservedDate)
                .FirstOrDefault();
        }


        /* Wishlist */
        public IEnumerable<Wishlist> GetWishlists(int id)
        {
            return _context.Wishlists
                .Include(w => w.Tutor)
                .Where(w => w.Tutor.Id == id);
        }

        public void PlaceReserveWishlist(int tutorId, int memberCardId)
        {
            var now = DateTime.Now;

            var tutor = _context.Tutors
                .Include(t=> t.ReserveOption)
                .First(t => t.Id == tutorId);
            var memberId = _context.MemberIDs
                .FirstOrDefault(m => m.Id == memberCardId);

            _context.Update(tutor);

            if(tutor.ReserveOption.Name == "Available")
            {
                tutor.ReserveOption = _context.ReserveOptions.FirstOrDefault(r => r.Name == "Tutor Wishlisted");
            }

            //create new wishlist
            var wishlist = new Wishlist
            {
                
                Tutor = tutor,
                MemberID = memberId
            };

            _context.Add(wishlist);
            _context.SaveChanges();

        }
        public string GetCurrReservationWishlistStudentName(int id)
        {
            var wishlist = _context.Wishlists
              .Include(a => a.Tutor)
              .Include(a => a.MemberID)
              .Where(v => v.Id == id);

            var memberId = wishlist
                .Include(a => a.MemberID)
                .Select(a => a.MemberID.Id)
                .FirstOrDefault();

            var student = _context.Students
                .Include(p => p.MemberID)
                .FirstOrDefault(p => p.MemberID.Id == memberId);

            return student.StudentName;
        }


        public string GetCurrStudent(int id)
        {
            var reserve = _context.Reserves
              .Include(a => a.Tutor)
              .Include(a => a.MemberID)
              .FirstOrDefault(v => v.Tutor.Id == id);

            if (reserve == null) {
                return "Available";
            }

            var memberId = reserve.MemberID.Id;

            var student = _context.Students
                .Include(p => p.MemberID)
                .First(p => p.MemberID.Id == memberId);

            return student.StudentName;
        }
    }
}
