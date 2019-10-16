namespace Primary_School_Management_System___2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Result : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExamType",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Result",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        SubjectID = c.Int(nullable: false),
                        ExamTypeID = c.Int(nullable: false),
                        Number = c.Single(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ExamType", t => t.ExamTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: false)
                .Index(t => t.StudentID)
                .Index(t => t.SubjectID)
                .Index(t => t.ExamTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Result", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.Result", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Result", "ExamTypeID", "dbo.ExamType");
            DropIndex("dbo.Result", new[] { "ExamTypeID" });
            DropIndex("dbo.Result", new[] { "SubjectID" });
            DropIndex("dbo.Result", new[] { "StudentID" });
            DropTable("dbo.Result");
            DropTable("dbo.ExamType");
        }
    }
}
