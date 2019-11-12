namespace UniversityManagementSystemWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version9 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 300, unicode: false));
            AlterColumn("dbo.Semisters", "Name", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Semisters", "Name", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Courses", "Description", c => c.String(nullable: false, maxLength: 8000, unicode: false));
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
    }
}
