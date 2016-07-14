using System.Data.Entity;
using Domain;

namespace DataAccess
{
    class UniversityContext : DbContext
    {
        public UniversityContext() : base("UniversityContext")
        {
            Database.SetInitializer(new UniversityInitializer());
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        
    }
}
