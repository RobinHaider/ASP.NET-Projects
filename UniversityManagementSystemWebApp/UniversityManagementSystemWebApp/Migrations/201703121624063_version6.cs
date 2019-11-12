namespace UniversityManagementSystemWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 30, unicode: false),
                        Name = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Credit = c.Double(nullable: false),
                        Description = c.String(nullable: false, maxLength: 8000, unicode: false),
                        DepartmentId = c.Int(nullable: false),
                        SemisterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Semisters", t => t.SemisterId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.SemisterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "SemisterId", "dbo.Semisters");
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "SemisterId" });
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            DropTable("dbo.Courses");
        }
    }
}
