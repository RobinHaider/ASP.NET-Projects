using System.Data.Entity;
using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Context
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Semister> Semisters { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<CourseAssign> CourseAssigns { get; set; }
        public DbSet<RegisterStudent> RegisterStudents { get; set; }

        public DbSet<EnrollCourse> EnrollCourses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<SaveResult> SaveResults { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<AllocateRoom> AllocateRooms { get; set; }



    }
}