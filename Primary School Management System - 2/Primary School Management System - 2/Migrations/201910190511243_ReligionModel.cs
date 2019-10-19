namespace Primary_School_Management_System___2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReligionModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Religion",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Student", "ReligionID", c => c.Int(nullable: false));
            AddColumn("dbo.Teacher", "ReligionID", c => c.Int(nullable: false));
            CreateIndex("dbo.Student", "ReligionID");
            CreateIndex("dbo.Teacher", "ReligionID");
            AddForeignKey("dbo.Student", "ReligionID", "dbo.Religion", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Teacher", "ReligionID", "dbo.Religion", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teacher", "ReligionID", "dbo.Religion");
            DropForeignKey("dbo.Student", "ReligionID", "dbo.Religion");
            DropIndex("dbo.Teacher", new[] { "ReligionID" });
            DropIndex("dbo.Student", new[] { "ReligionID" });
            DropColumn("dbo.Teacher", "ReligionID");
            DropColumn("dbo.Student", "ReligionID");
            DropTable("dbo.Religion");
        }
    }
}
