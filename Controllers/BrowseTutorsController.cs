using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TutorMangementSystem.Models.BrowseTutors;
using TutorMangementSystem.Models.ReserveModels;


namespace TutorMangementSystem.Controllers
{
    public class BrowseTutorsController : Controller
    {
        private ITutor _tutors;
        private IReserve _reserves;

        public BrowseTutorsController(ITutor tutors, IReserve reserves)
        {
            _tutors = tutors;
            _reserves = reserves;
        }
        public IActionResult Index()
        {
            var tutorModels = _tutors.GetAll();

            var listResult = tutorModels.Select(result => new TutorIndexModel
            {
                Id = result.Id,
                TutorName = result.TutorName,
                Subject = result.Subject,
                Cost = result.Cost,
                TutorIMG = result.TutorIMG
            });

            var model = new TutorIndexModelCollection()
            {
                Tutors = listResult
            };

            return View(model);
        }

        public IActionResult Info(int id)
        {
            var tutor = _tutors.GetById(id);

            var currWishlist = _reserves.GetWishlists(id).Select(a => new WishlistModel
            {
                //WishlistCreated = _reserves.GetC(a.Id),
                StudentName = _reserves.GetCurrReservationWishlistStudentName(a.Id)
            });

            var model = new TutorInfoModel
            {
                TutorId = id,
                TutorName = tutor.TutorName,
                Subject = tutor.Subject,
                Cost = tutor.Cost,
                TutorIMG = tutor.TutorIMG,
                ReserveOption = tutor.ReserveOption.Name,
                OfficeLocation = _tutors.GetOfficeLocation(id).Name,
                StudentName = _reserves.GetCurrStudent(id),
                RecentReserve = _reserves.GetRecentReserve(id),
                ReservationsRegister = _reserves.GetRegisters(id),
                CurrWishlist = currWishlist

            };
            return View(model);
        }

        public IActionResult Reserve(int id)
        {
            var tutor = _tutors.GetById(id);

            var model = new ReserveModel
            {
                TutorId = id,
                Tutor = tutor.TutorName,
                MemberId = "",
                IMG = tutor.TutorIMG,
                IsReserved = _reserves.IsReserved(id)


            };

            return View(model);
        }

        public IActionResult Wishlist(int id)
        {
            var tutor = _tutors.GetById(id);

            var model = new ReserveModel
            {
                TutorId = id,
                Tutor = tutor.TutorName,
                MemberId = "",
                IMG = tutor.TutorIMG,
                IsReserved = _reserves.IsReserved(id),
                WishlistCount = _reserves.GetCurrReservationWishlistStudentName(id).Count()


            };

            return View(model);
        }

        public IActionResult UnReserve(int id)
        {
            _reserves.AvailableTutor(id);
            return RedirectToAction("Info", new { id = id });
        }

        [HttpPost]
        public IActionResult AddReservation(int tutorId, int memberId)
        {
            _reserves.ReservedTutor(tutorId, memberId);
            return RedirectToAction("Info", new { id = tutorId });
        }
        [HttpPost]
        public IActionResult AddToWishlist(int id, int memberId)
        {
            _reserves.PlaceReserveWishlist(id, memberId);
            return RedirectToAction("Info", new { id = id });
        }
    }
}