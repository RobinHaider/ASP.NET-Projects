namespace UniversityManagementSystemWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _15904pm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegisterStudents", "RegistationNumber", c => c.String(maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RegisterStudents", "RegistationNumber");
        }
    }
}
