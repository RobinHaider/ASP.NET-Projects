namespace Primary_School_Management_System___2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherAndSubject : DbMigration
    {
        public override void Up()
        {
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
            DropForeignKey("dbo.Subject", "TeacherID", "dbo.Teacher");
            DropForeignKey("dbo.Subject", "ClassID", "dbo.Class");
            DropIndex("dbo.Subject", new[] { "TeacherID" });
            DropIndex("dbo.Subject", new[] { "ClassID" });
            DropTable("dbo.Teacher");
            DropTable("dbo.Subject");
        }
    }
}
