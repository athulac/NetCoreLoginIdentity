using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PracticalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest.Domain
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }
        public DbSet<Mark> Marks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {                

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Teacher>().HasData(
               new Teacher { Id = 1, Name = "jayamini" },
               new Teacher { Id = 2, Name = "lakmi" },
               new Teacher { Id = 3, Name = "perera" },
               new Teacher { Id = 4, Name = "kusal" },
               new Teacher { Id = 5, Name = "nirmani" },
               new Teacher { Id = 6, Name = "jeewa" });

            modelBuilder.Entity<School>().HasData(
              new School { Id = 1, Name = "maliyadeva", Address = "kurunegala" },
              new School { Id = 2, Name = "presedents", Address = "panadura" });

            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "art" },
                new Subject { Id = 2, Name = "sinhala" },
                new Subject { Id = 3, Name = "maths" });

            modelBuilder.Entity<Grade>().HasData(
                new Grade { Id = 1, Name = 10 },
                new Grade { Id = 2, Name = 9 },
                new Grade { Id = 3, Name = 11 },
                new Grade { Id = 4, Name = 8 },
                new Grade { Id = 5, Name = 12 });

           modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "A", Dob = Convert.ToDateTime("02/13/1990"), GradeId = 1, SchoolId = 1},
                new Student { Id = 2, Name = "B", Dob = Convert.ToDateTime("05/16/1994"), GradeId = 2, SchoolId = 1},
                new Student { Id = 3, Name = "C", Dob = Convert.ToDateTime("08/12/1997"), GradeId = 3, SchoolId = 1},
                new Student { Id = 4, Name = "D", Dob = Convert.ToDateTime("01/05/1989"), GradeId = 4, SchoolId = 2},
                new Student { Id = 5, Name = "E", Dob = Convert.ToDateTime("04/30/1992"), GradeId = 3, SchoolId = 1},
                new Student { Id = 6, Name = "F", Dob = Convert.ToDateTime("08/12/1994"), GradeId = 5, SchoolId = 1}              
                );

            modelBuilder.Entity<TeacherSubject>().HasData(
                 new TeacherSubject { Id = 1, TeacherId = 1, SubjectId = 1 },
                 new TeacherSubject { Id = 2, TeacherId = 2, SubjectId = 2 },
                 new TeacherSubject { Id = 3, TeacherId = 3, SubjectId = 3 },
                 new TeacherSubject { Id = 4, TeacherId = 4, SubjectId = 2 },
                 new TeacherSubject { Id = 5, TeacherId = 5, SubjectId = 2 },
                 new TeacherSubject { Id = 6, TeacherId = 6, SubjectId = 1 }                 
                 );


        }
    }
}
