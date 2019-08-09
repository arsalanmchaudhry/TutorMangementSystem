using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorMangementSystem.Models.BrowseTutors
{
    public class TutorInfoModel
    {
        public int TutorId { get; set; }
        public string TutorName { get; set; }
        public string Subject { get; set; }
        public decimal Cost { get; set; }
        public string TutorIMG { get; set; }
        public string ReserveOption { get; set; }
        public string OfficeLocation { get; set; }
        public string StudentName { get; set; }
        public Reserve RecentReserve { get; set; }
        public IEnumerable<Register> ReservationsRegister { get; set; }
        public IEnumerable<WishlistModel> CurrWishlist { get; set; }
    }

    public class WishlistModel
    {
        public string StudentName { get; set; }
        public string WishlistCreated { get; set; }
    }
}
