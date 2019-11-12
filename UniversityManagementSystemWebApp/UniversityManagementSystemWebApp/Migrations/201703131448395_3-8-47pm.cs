namespace UniversityManagementSystemWebApp.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class _3847pm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseAssigns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.CourseId)
                .Index(t => t.DepartmentId)
                .Index(t => t.TeacherId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.CourseAssigns", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.CourseAssigns", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.CourseAssigns", "CourseId", "dbo.Courses");
            DropIndex("dbo.CourseAssigns", new[] { "TeacherId" });
            DropIndex("dbo.CourseAssigns", new[] { "DepartmentId" });
            DropIndex("dbo.CourseAssigns", new[] { "CourseId" });
            DropTable("dbo.CourseAssigns");
        }
    }
}
