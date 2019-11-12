namespace UniversityManagementSystemWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _171056am : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EnrollCourses", "Name");
            DropColumn("dbo.EnrollCourses", "Email");
            DropColumn("dbo.EnrollCourses", "Department");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EnrollCourses", "Department", c => c.String());
            AddColumn("dbo.EnrollCourses", "Email", c => c.String());
            AddColumn("dbo.EnrollCourses", "Name", c => c.String());
        }
    }
}
