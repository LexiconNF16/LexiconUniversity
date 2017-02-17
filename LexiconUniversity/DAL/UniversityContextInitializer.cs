using LexiconUniversity.Models;
using System;
using System.Data.Entity;

namespace LexiconUniversity.DAL
{
    internal class UniversityContextInitializer : DropCreateDatabaseAlways<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            var courses = new [] {
                new Course { CourseId = 1050, Name = ".NET", Credits = 30 },
                new Course { CourseId = 1060, Name = "Java", Credits = 28 },
                new Course { CourseId = 2010, Name = "Redirect for dummies", Credits = 4 },
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();

            var students = new [] {
                new Student { FirstName = "Adam", LastName = "Andersson"  },
                new Student { FirstName = "Berit", LastName = "Bosson"},
                new Student { FirstName = "Cecilia", LastName = "Carlsson"},
                new Student { FirstName = "David", LastName = "Duke"},
            };
            context.Students.AddRange(students);
            context.SaveChanges();

            var enrollments = new [] {
                new Enrollment { StudentId = students[0].Id, CourseId = 1050, EnrollmentDate = DateTime.Parse("2017-01-12"), Grade = Grade.A },
                new Enrollment { StudentId = students[1].Id, CourseId = 1050, EnrollmentDate = DateTime.Parse("2017-02-02"), Grade = Grade.B },
                new Enrollment { StudentId = students[0].Id, CourseId = 1060, EnrollmentDate = DateTime.Today  },
                new Enrollment { StudentId = students[1].Id, CourseId = 1060, EnrollmentDate = DateTime.Today  },
                new Enrollment { StudentId = students[2].Id, CourseId = 1060, EnrollmentDate = DateTime.Parse("2016-12-21"), Grade = Grade.C },
                new Enrollment { StudentId = students[3].Id, CourseId = 1050, EnrollmentDate = DateTime.Parse("2017-01-14"), Grade = Grade.F },
            };
            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }

    }
}