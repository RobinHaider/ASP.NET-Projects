namespace UniversityManagementSystemWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _17442pm : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SaveResults", "Name");
            DropColumn("dbo.SaveResults", "Email");
            DropColumn("dbo.SaveResults", "Department");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SaveResults", "Department", c => c.String());
            AddColumn("dbo.SaveResults", "Email", c => c.String());
            AddColumn("dbo.SaveResults", "Name", c => c.String());
        }
    }
}
