using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorMangementSystem.Models;

namespace TutorMangementSystem
{
    public interface IReserve
    {
        IEnumerable<Reserve> GetAll();
        Reserve GetByReserveId(int reserveId);
        void CreateReserve(Reserve newReserve);
        void ReservedTutor(int tutorId, int memberCardId);
        void AvailableTutor(int tutorId);
        IEnumerable<Register> GetRegisters(int id);
        Reserve GetRecentReserve(int id);
        string GetCurrStudent(int id);
        bool IsReserved(int id);

        void PlaceReserveWishlist(int tutorId, int memberCardId);
        string GetCurrReservationWishlistStudentName(int id);
        IEnumerable<Wishlist> GetWishlists(int id);

    }
}
