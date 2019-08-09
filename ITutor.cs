using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutorMangementSystem.Models;

namespace TutorMangementSystem
{
    public interface ITutor
    {
        IEnumerable<Tutor> GetAll();
        Tutor GetById(int id);

        void AddTutor(Tutor newTutor);
        string GetSubject(int id);
        string GetName(int id);

        Office GetOfficeLocation(int id);






    }
}
