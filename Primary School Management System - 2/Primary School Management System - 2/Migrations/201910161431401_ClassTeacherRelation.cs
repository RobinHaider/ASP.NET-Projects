namespace Primary_School_Management_System___2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassTeacherRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Class", "TeacherID", c => c.Int());
            CreateIndex("dbo.Class", "TeacherID");
            AddForeignKey("dbo.Class", "TeacherID", "dbo.Teacher", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Class", "TeacherID", "dbo.Teacher");
            DropIndex("dbo.Class", new[] { "TeacherID" });
            DropColumn("dbo.Class", "TeacherID");
        }
    }
}
