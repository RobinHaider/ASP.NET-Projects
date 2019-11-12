


using UniversityManagementSystemWebApp.Models;

namespace UniversityManagementSystemWebApp.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<UniversityManagementSystemWebApp.Context.UniversityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UniversityManagementSystemWebApp.Context.UniversityDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //Departments............
            context.Departments.AddOrUpdate(
                new Department() { Id = 1, Code = "EEE", Name = "Eletrical and Electronics Engineering" },
                new Department() { Id = 2, Code = "CSE", Name = "Computer Science and Engineering" },
                new Department() { Id = 3, Code = "ETE", Name = "Electrical and Telecommunication Engineering" },
                new Department() { Id = 4, Code = "CE", Name = "Civil Engineering" },
                new Department() { Id = 5, Code = "BBA", Name = "Bachelor of Business Administration" },
                new Department() { Id = 5, Code = "DP", Name = "Department of Pharmacy" }
                );

            //Designations......
            context.Designations.AddOrUpdate(
                new Designation() { Id = 1, Name = "Associate Professor" },
                new Designation() { Id = 2, Name = "Advisor" },
                new Designation() { Id = 3, Name = "Associate Professor" },
                new Designation() { Id = 4, Name = "Assistant Professor" },
                new Designation() { Id = 5, Name = "Lecturer" },
                new Designation() { Id = 6, Name = "Senior Lecturer" },
                new Designation() { Id = 7, Name = "Enginner" }
                );


            //Semisters..............
            context.Semisters.AddOrUpdate(
                new Semister() { Id = 1, Name = "1st" },
                new Semister() { Id = 2, Name = "2nd" },
                new Semister() { Id = 3, Name = "3rd" },
                new Semister() { Id = 4, Name = "4th" },
                new Semister() { Id = 5, Name = "5th" },
                new Semister() { Id = 6, Name = "6th" },
                new Semister() { Id = 7, Name = "7th" },
                new Semister() { Id = 8, Name = "8th" }
            );

            //Grades..............
            context.Grades.AddOrUpdate(
                new Grade() { Id = 1, Name = "A+" },
                new Grade() { Id = 2, Name = "A" },
                new Grade() { Id = 3, Name = "A-" },
                new Grade() { Id = 4, Name = "B+" },
                new Grade() { Id = 5, Name = "B" },
                new Grade() { Id = 6, Name = "B-" },
                new Grade() { Id = 7, Name = "C+" },
                new Grade() { Id = 8, Name = "C" },
                new Grade() { Id = 9, Name = "C-" },
                new Grade() { Id = 10, Name = "D+" },
                new Grade() { Id = 11, Name = "D" },
                new Grade() { Id = 12, Name = "D-" },
                new Grade() { Id = 13, Name = "F" }
                );

            //days......................
            context.Days.AddOrUpdate(
                new Day() { Id = 1, Name = "Saturday" },
                new Day() { Id = 2, Name = "Sunday" },
                new Day() { Id = 3, Name = "Monday" },
                new Day() { Id = 4, Name = "Tuesday" },
                new Day() { Id = 5, Name = "Wednesday" },
                new Day() { Id = 6, Name = "Thursday" },
                new Day() { Id = 7, Name = "Friday" }
                );

            //Room...........................
            context.Rooms.AddOrUpdate(
                new Room() { Id = 1, Name = "401" },
                new Room() { Id = 2, Name = "402" },
                new Room() { Id = 3, Name = "403" },
                new Room() { Id = 4, Name = "404" },
                new Room() { Id = 5, Name = "501" },
                new Room() { Id = 6, Name = "502" },
                new Room() { Id = 7, Name = "503" },
                new Room() { Id = 8, Name = "504" }
                );
        }
    }
}
