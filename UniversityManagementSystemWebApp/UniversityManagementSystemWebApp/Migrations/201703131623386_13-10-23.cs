namespace UniversityManagementSystemWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _131023 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourseAssigns", "CreditToBeTaken", c => c.Double(nullable: false));
            AddColumn("dbo.CourseAssigns", "ReaminingCredit", c => c.Double(nullable: false));
            AddColumn("dbo.CourseAssigns", "Name", c => c.String());
            AddColumn("dbo.CourseAssigns", "Credit", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CourseAssigns", "Credit");
            DropColumn("dbo.CourseAssigns", "Name");
            DropColumn("dbo.CourseAssigns", "ReaminingCredit");
            DropColumn("dbo.CourseAssigns", "CreditToBeTaken");
        }
    }
}
