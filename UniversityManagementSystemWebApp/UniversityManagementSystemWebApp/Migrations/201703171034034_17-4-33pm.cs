namespace UniversityManagementSystemWebApp.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class _17433pm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SaveResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegisterStudentId = c.Int(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Department = c.String(),
                        CourseId = c.Int(nullable: false),
                        GradeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Grades", t => t.GradeId)
                .ForeignKey("dbo.RegisterStudents", t => t.RegisterStudentId)
                .Index(t => t.CourseId)
                .Index(t => t.GradeId)
                .Index(t => t.RegisterStudentId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.SaveResults", "RegisterStudentId", "dbo.RegisterStudents");
            DropForeignKey("dbo.SaveResults", "GradeId", "dbo.Grades");
            DropForeignKey("dbo.SaveResults", "CourseId", "dbo.Courses");
            DropIndex("dbo.SaveResults", new[] { "RegisterStudentId" });
            DropIndex("dbo.SaveResults", new[] { "GradeId" });
            DropIndex("dbo.SaveResults", new[] { "CourseId" });
            DropTable("dbo.SaveResults");
        }
    }
}
