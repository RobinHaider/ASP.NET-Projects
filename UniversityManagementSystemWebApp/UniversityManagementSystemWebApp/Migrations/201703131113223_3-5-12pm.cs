namespace UniversityManagementSystemWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3512pm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Address", c => c.String(nullable: false, maxLength: 300, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Address");
        }
    }
}
