namespace UniPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BuildingName = c.String(nullable: false),
                        Address = c.String(),
                        UniverId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Univers", t => t.UniverId, cascadeDelete: true)
                .Index(t => t.UniverId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoomName = c.String(nullable: false),
                        BuildingId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buildings", t => t.BuildingId, cascadeDelete: true)
                .Index(t => t.BuildingId);
            
            CreateTable(
                "dbo.StudentGroups",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StudentGroupName = c.String(nullable: false),
                        StartYear = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoleName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Univers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UniverName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoleUsers",
                c => new
                    {
                        Role_Id = c.Guid(nullable: false),
                        User_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Role_Id, t.User_Id })
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Role_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.UserStudentGroups",
                c => new
                    {
                        User_Id = c.Guid(nullable: false),
                        StudentGroup_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.StudentGroup_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.StudentGroups", t => t.StudentGroup_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.StudentGroup_Id);
            
            AddColumn("dbo.Lessons", "RoomId", c => c.Guid(nullable: false));
            AddColumn("dbo.Lessons", "StudentGroupId", c => c.Guid(nullable: false));
            AddColumn("dbo.Lessons", "ActualYear", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Lessons", "RoomId");
            CreateIndex("dbo.Lessons", "StudentGroupId");
            AddForeignKey("dbo.Lessons", "RoomId", "dbo.Rooms", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Lessons", "StudentGroupId", "dbo.StudentGroups", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buildings", "UniverId", "dbo.Univers");
            DropForeignKey("dbo.UserStudentGroups", "StudentGroup_Id", "dbo.StudentGroups");
            DropForeignKey("dbo.UserStudentGroups", "User_Id", "dbo.Users");
            DropForeignKey("dbo.RoleUsers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.RoleUsers", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Lessons", "StudentGroupId", "dbo.StudentGroups");
            DropForeignKey("dbo.Lessons", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "BuildingId", "dbo.Buildings");
            DropIndex("dbo.UserStudentGroups", new[] { "StudentGroup_Id" });
            DropIndex("dbo.UserStudentGroups", new[] { "User_Id" });
            DropIndex("dbo.RoleUsers", new[] { "User_Id" });
            DropIndex("dbo.RoleUsers", new[] { "Role_Id" });
            DropIndex("dbo.Lessons", new[] { "StudentGroupId" });
            DropIndex("dbo.Lessons", new[] { "RoomId" });
            DropIndex("dbo.Rooms", new[] { "BuildingId" });
            DropIndex("dbo.Buildings", new[] { "UniverId" });
            DropColumn("dbo.Lessons", "ActualYear");
            DropColumn("dbo.Lessons", "StudentGroupId");
            DropColumn("dbo.Lessons", "RoomId");
            DropTable("dbo.UserStudentGroups");
            DropTable("dbo.RoleUsers");
            DropTable("dbo.Univers");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.StudentGroups");
            DropTable("dbo.Rooms");
            DropTable("dbo.Buildings");
        }
    }
}
