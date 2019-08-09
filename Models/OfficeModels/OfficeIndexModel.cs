using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorMangementSystem.Models.OfficeModels
{
    public class OfficeIndexModel
    {
        public IEnumerable<OfficeDetailModel> Offices { get; set; }
    }
}
