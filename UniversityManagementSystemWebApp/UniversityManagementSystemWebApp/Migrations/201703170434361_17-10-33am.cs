namespace UniversityManagementSystemWebApp.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class _171033am : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EnrollCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegisterStudentId = c.Int(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Department = c.String(),
                        CourseId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.RegisterStudents", t => t.RegisterStudentId)
                .Index(t => t.CourseId)
                .Index(t => t.RegisterStudentId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.EnrollCourses", "RegisterStudentId", "dbo.RegisterStudents");
            DropForeignKey("dbo.EnrollCourses", "CourseId", "dbo.Courses");
            DropIndex("dbo.EnrollCourses", new[] { "RegisterStudentId" });
            DropIndex("dbo.EnrollCourses", new[] { "CourseId" });
            DropTable("dbo.EnrollCourses");
        }
    }
}
