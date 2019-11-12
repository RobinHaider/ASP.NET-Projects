namespace UniversityManagementSystemWebApp.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class _18439pm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllocateRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        DayId = c.Int(nullable: false),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .ForeignKey("dbo.Days", t => t.DayId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId)
                .ForeignKey("dbo.Rooms", t => t.RoomId)
                .Index(t => t.CourseId)
                .Index(t => t.DayId)
                .Index(t => t.DepartmentId)
                .Index(t => t.RoomId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.AllocateRooms", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.AllocateRooms", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.AllocateRooms", "DayId", "dbo.Days");
            DropForeignKey("dbo.AllocateRooms", "CourseId", "dbo.Courses");
            DropIndex("dbo.AllocateRooms", new[] { "RoomId" });
            DropIndex("dbo.AllocateRooms", new[] { "DepartmentId" });
            DropIndex("dbo.AllocateRooms", new[] { "DayId" });
            DropIndex("dbo.AllocateRooms", new[] { "CourseId" });
            DropTable("dbo.AllocateRooms");
        }
    }
}
