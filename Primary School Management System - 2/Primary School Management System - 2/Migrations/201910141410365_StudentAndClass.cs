namespace Primary_School_Management_System___2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentAndClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Class",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "ClassID", "dbo.Class");
            DropIndex("dbo.Student", new[] { "ClassID" });
            DropTable("dbo.Student");
            DropTable("dbo.Class");
        }
    }
}
