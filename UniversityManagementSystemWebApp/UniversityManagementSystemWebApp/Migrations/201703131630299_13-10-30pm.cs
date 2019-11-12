namespace UniversityManagementSystemWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _131030pm : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CourseAssigns", "CreditToBeTaken");
            DropColumn("dbo.CourseAssigns", "ReaminingCredit");
            DropColumn("dbo.CourseAssigns", "Name");
            DropColumn("dbo.CourseAssigns", "Credit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CourseAssigns", "Credit", c => c.Int(nullable: false));
            AddColumn("dbo.CourseAssigns", "Name", c => c.String());
            AddColumn("dbo.CourseAssigns", "ReaminingCredit", c => c.Double(nullable: false));
            AddColumn("dbo.CourseAssigns", "CreditToBeTaken", c => c.Double(nullable: false));
        }
    }
}
