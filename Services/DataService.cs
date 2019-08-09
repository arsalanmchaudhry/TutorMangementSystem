using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorMangementSystem.Models;

namespace TutorMangementSystem.Services
{
    public class DataService 
    {
        public static IEnumerable<string> ReadbleHours(IEnumerable<OfficeHours> officeHours)
        {
            var hours = new List<string>();

            foreach (var time in officeHours)
            {
                var day = Day(time.DayOfWeek);
                var openTime = Time(time.OpenTime);
                var closeTime = Time(time.CloseTime);
                var timeEntry = $"{day} {openTime} to {closeTime}";
                hours.Add(timeEntry);
            }

            return hours;
        }

        private static string Day(int number)
        {
            return Enum.GetName(typeof(DayOfWeek), number);
        }

        private static string Time(int time)
        {
            var result = TimeSpan.FromHours(time);
            return result.ToString("hh':'mm");
        }
    }
}
