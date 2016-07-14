using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Domain;

namespace DataAccess
{
    internal class UniversityInitializer : DropCreateDatabaseAlways<UniversityContext>
    {
        public override void InitializeDatabase(UniversityContext context)
        {
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
                , string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

            base.InitializeDatabase(context);
        }
        protected override void Seed(UniversityContext context)
        {
            var students = new List<Student>
            {
                new Student{FirstMidName="Carson",LastName="Alexander",SecondName = "Bob", EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.AddOrUpdate(s));            
            context.SaveChanges();
            var courses = new List<Course>
            {
                new Course{Title="Chemistry",Credits=3,},
                new Course{Title="Microeconomics",Credits=3,},
                new Course{Title="Macroeconomics",Credits=3,},
                new Course{Title="Calculus",Credits=4,},
                new Course{Title="Trigonometry",Credits=4,},
                new Course{Title="Composition",Credits=3,},
                new Course{Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.AddOrUpdate(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentId=1,CourseId=1,Grade=Grade.A},
                new Enrollment{StudentId=1,CourseId=2,Grade=Grade.C},
                new Enrollment{StudentId=1,CourseId=3,Grade=Grade.B},
                new Enrollment{StudentId=2,CourseId=4,Grade=Grade.B},
                new Enrollment{StudentId=2,CourseId=5,Grade=Grade.F},
                new Enrollment{StudentId=2,CourseId=6,Grade=Grade.F},
                new Enrollment{StudentId=3,CourseId=1},
                new Enrollment{StudentId=4,CourseId=1,},
                new Enrollment{StudentId=4,CourseId=2,Grade=Grade.F},
                new Enrollment{StudentId=5,CourseId=3,Grade=Grade.C},
                new Enrollment{StudentId=6,CourseId=4},
                new Enrollment{StudentId=7,CourseId=5,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
