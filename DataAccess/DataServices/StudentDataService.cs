using System.Collections.Generic;
using System.Linq;
using Domain;

namespace DataAccess.DataServices
{
    public class StudentDataService
    {
        public List<Student> GetAll()
        {
            using (var context = new UniversityContext())
            {
                return context.Students.ToList();
            }
        }

        public void Add(Student student)
        {
            using (var context = new UniversityContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}
