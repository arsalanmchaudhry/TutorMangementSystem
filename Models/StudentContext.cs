using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TutorMangementSystem.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<MemberID> MemberIDs { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<OfficeHours> OfficeHours { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Reserve> Reserves { get; set; }
        public DbSet<ReserveOption> ReserveOptions { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
    }
}
