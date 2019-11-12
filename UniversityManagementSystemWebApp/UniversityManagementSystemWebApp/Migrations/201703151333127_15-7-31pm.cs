namespace UniversityManagementSystemWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _15731pm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegisterStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        Contact = c.String(nullable: false, maxLength: 16, unicode: false),
                        Date = c.DateTime(nullable: false),
                        Address = c.String(nullable: false, maxLength: 300, unicode: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegisterStudents", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.RegisterStudents", new[] { "DepartmentId" });
            DropTable("dbo.RegisterStudents");
        }
    }
}
