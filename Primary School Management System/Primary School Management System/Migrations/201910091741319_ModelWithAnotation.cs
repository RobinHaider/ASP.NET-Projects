namespace Primary_School_Management_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelWithAnotation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                        TeacherID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teacher", t => t.TeacherID)
                .Index(t => t.TeacherID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RollNo = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                        FatherName = c.String(nullable: false, maxLength: 50),
                        MotherName = c.String(nullable: false, maxLength: 50),
                        ClassID = c.Int(nullable: false),
                        Address = c.String(nullable: false, maxLength: 100),
                        GuardianMobileNumber = c.String(nullable: false),
                        GuardianEmail = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Class", t => t.ClassID, cascadeDelete: true)
                .Index(t => t.ClassID);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ClassID = c.Int(nullable: false),
                        TeacherID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Class", t => t.ClassID, cascadeDelete: true)
                .ForeignKey("dbo.Teacher", t => t.TeacherID)
                .Index(t => t.ClassID)
                .Index(t => t.TeacherID);
            
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(),
                        MobileNumber = c.String(nullable: false),
                        Address = c.String(nullable: false, maxLength: 100),
                        NID = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Class", "TeacherID", "dbo.Teacher");
            DropForeignKey("dbo.Subject", "TeacherID", "dbo.Teacher");
            DropForeignKey("dbo.Subject", "ClassID", "dbo.Class");
            DropForeignKey("dbo.Student", "ClassID", "dbo.Class");
            DropIndex("dbo.Subject", new[] { "TeacherID" });
            DropIndex("dbo.Subject", new[] { "ClassID" });
            DropIndex("dbo.Student", new[] { "ClassID" });
            DropIndex("dbo.Class", new[] { "TeacherID" });
            DropTable("dbo.Teacher");
            DropTable("dbo.Subject");
            DropTable("dbo.Student");
            DropTable("dbo.Class");
        }
    }
}
