namespace Rad301August2017.Migrations.AttendenceMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendences",
                c => new
                    {
                        AttendenceID = c.Int(nullable: false, identity: true),
                        AttendenceDate = c.DateTime(nullable: false),
                        SubjectID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AttendenceID)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.SubjectID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentFName = c.String(),
                        StudentLName = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.StudentSubject",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        SubjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Student", t => t.StudentID)
                .ForeignKey("dbo.Subject", t => t.SubjectID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.SubjectID);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        SubjectID = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                        StudentSubject_StudentID = c.Int(),
                        LecturerSubject_SubjectID = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectID)
                .ForeignKey("dbo.StudentSubject", t => t.StudentSubject_StudentID)
                .ForeignKey("dbo.Lecturer Subject", t => t.LecturerSubject_SubjectID)
                .Index(t => t.StudentSubject_StudentID)
                .Index(t => t.LecturerSubject_SubjectID);
            
            CreateTable(
                "dbo.Lecturer",
                c => new
                    {
                        LecturerID = c.Int(nullable: false, identity: true),
                        LecturerName = c.String(),
                    })
                .PrimaryKey(t => t.LecturerID);
            
            CreateTable(
                "dbo.Lecturer Subject",
                c => new
                    {
                        SubjectID = c.Int(nullable: false, identity: true),
                        LecturerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubjectID)
                .ForeignKey("dbo.Lecturer", t => t.LecturerID, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.SubjectID)
                .Index(t => t.SubjectID)
                .Index(t => t.LecturerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subject", "LecturerSubject_SubjectID", "dbo.Lecturer Subject");
            DropForeignKey("dbo.Lecturer Subject", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.Lecturer Subject", "LecturerID", "dbo.Lecturer");
            DropForeignKey("dbo.Attendences", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.Attendences", "StudentID", "dbo.Student");
            DropForeignKey("dbo.Subject", "StudentSubject_StudentID", "dbo.StudentSubject");
            DropForeignKey("dbo.StudentSubject", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.StudentSubject", "StudentID", "dbo.Student");
            DropIndex("dbo.Lecturer Subject", new[] { "LecturerID" });
            DropIndex("dbo.Lecturer Subject", new[] { "SubjectID" });
            DropIndex("dbo.Subject", new[] { "LecturerSubject_SubjectID" });
            DropIndex("dbo.Subject", new[] { "StudentSubject_StudentID" });
            DropIndex("dbo.StudentSubject", new[] { "SubjectID" });
            DropIndex("dbo.StudentSubject", new[] { "StudentID" });
            DropIndex("dbo.Attendences", new[] { "StudentID" });
            DropIndex("dbo.Attendences", new[] { "SubjectID" });
            DropTable("dbo.Lecturer Subject");
            DropTable("dbo.Lecturer");
            DropTable("dbo.Subject");
            DropTable("dbo.StudentSubject");
            DropTable("dbo.Student");
            DropTable("dbo.Attendences");
        }
    }
}
