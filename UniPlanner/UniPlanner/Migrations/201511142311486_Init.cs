namespace UniPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CourseName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SequenceId = c.Guid(nullable: false),
                        LessonTypeId = c.Guid(nullable: false),
                        DayId = c.Guid(nullable: false),
                        WeekTypeId = c.Guid(nullable: false),
                        CourseId = c.Guid(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Semester = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Days", t => t.DayId, cascadeDelete: true)
                .ForeignKey("dbo.LessonTypes", t => t.LessonTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Sequences", t => t.SequenceId, cascadeDelete: true)
                .ForeignKey("dbo.WeekTypes", t => t.WeekTypeId, cascadeDelete: true)
                .Index(t => t.SequenceId)
                .Index(t => t.LessonTypeId)
                .Index(t => t.DayId)
                .Index(t => t.WeekTypeId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DayName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LessonTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sequences",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SequenceName = c.String(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeekTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        WeekName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Lessons", "WeekTypeId", "dbo.WeekTypes");
            DropForeignKey("dbo.Lessons", "SequenceId", "dbo.Sequences");
            DropForeignKey("dbo.Lessons", "LessonTypeId", "dbo.LessonTypes");
            DropForeignKey("dbo.Lessons", "DayId", "dbo.Days");
            DropForeignKey("dbo.Lessons", "CourseId", "dbo.Courses");
            DropIndex("dbo.Lessons", new[] { "CourseId" });
            DropIndex("dbo.Lessons", new[] { "WeekTypeId" });
            DropIndex("dbo.Lessons", new[] { "DayId" });
            DropIndex("dbo.Lessons", new[] { "LessonTypeId" });
            DropIndex("dbo.Lessons", new[] { "SequenceId" });
            DropTable("dbo.WeekTypes");
            DropTable("dbo.Sequences");
            DropTable("dbo.LessonTypes");
            DropTable("dbo.Days");
            DropTable("dbo.Lessons");
            DropTable("dbo.Courses");
        }
    }
}
