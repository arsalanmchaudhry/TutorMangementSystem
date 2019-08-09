using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TutorMangementSystem.Models;
using TutorMangementSystem.Models.OfficeModels;

namespace TutorMangementSystem.Controllers
{
    public class HomeController : Controller

    {

        private IOffice _office;

        public HomeController(IOffice office)
        {
            _office = office;
        }
        public IActionResult BranchLocation()
        {
            var officeModels = _office.GetAll()
               .Select(br => new OfficeDetailModel
               {
                   Id = br.Id,
                   OfficeName = br.Name,
                   NumberOfTutors = _office.GetTutorCount(br.Id),
                   NumberOfStudents = _office.GetStudentCount(br.Id),
                   IsOpen = _office.IsOfficeOpen(br.Id)
               }).ToList();

            var model = new OfficeIndexModel
            {
                Offices = officeModels
            };

            return View(model);

        }
        public IActionResult OfficeDetail(int id)
        {
            var office = _office.Get(id);
            var model = new OfficeDetailModel
            {
                OfficeName = office.Name,
                Description = office.Description,
                Address = office.Address,
                Telephone = office.Telephone,
                OfficeOpenDate = office.OpenDate.ToString("yyyy-MM-dd"),
                NumberOfStudents = _office.GetStudentCount(id),
                NumberOfTutors = _office.GetTutorCount(id),
                OfficeImg = office.OfficeIMG,
                HoursOpen = _office.GetOfficeHours(id)
            };

            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Branch()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
