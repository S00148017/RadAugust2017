namespace Rad301August2017.Migrations.AttendenceMigrations
{
    using Models.AttendenceModel;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Rad301August2017.Models.AttendenceModel.AttendDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\AttendenceMigrations";
        }

        protected override void Seed(Rad301August2017.Models.AttendenceModel.AttendDBContext context)
        {
            context.Subjects.AddOrUpdate(sbj => sbj.SubjectName,
                new Models.AttendenceModel.Subject { SubjectID =01, SubjectName = "RAD301" });

            context.Subjects.AddOrUpdate(sbj => sbj.SubjectName,
                new Models.AttendenceModel.Subject { SubjectID = 02, SubjectName = "RAD302" });

            context.Subjects.AddOrUpdate(sbj => sbj.SubjectName,
                new Models.AttendenceModel.Subject { SubjectID = 03, SubjectName = "WEB" });

            context.Subjects.AddOrUpdate(sbj => sbj.SubjectName,
                new Models.AttendenceModel.Subject { SubjectID = 04, SubjectName = "Games" });

            context.Students.AddOrUpdate(s => s.StudentFName,
               new Models.AttendenceModel.Student
               {
                   StudentFName = "Damien",
                   StudentLName = "Henry",
                   StudentID = 00148017,

               });

               context.Students.AddOrUpdate(s => s.StudentFName,
               new Student
               {
                   StudentFName = "John",
                   StudentLName = "Smith",
                   StudentID = 00000001,

               });

            context.Lecturers.AddOrUpdate(lec => lec.LecturerName, new Lecturer
            {
                LecturerName = "Paul",
                LecturerID = 123,
                lecSubjects = new List<Subject>()
                {
                    new Subject {SubjectID=01, SubjectName="RAD301",subjects = new List<LecturerSubject>()
                    {
                        new LecturerSubject {SubjectID=01, LecturerID =123 },
                    }
                }
                }
             });

            context.Lecturers.AddOrUpdate(lec => lec.LecturerName, new Lecturer
            {
                LecturerName = "Neil",
                LecturerID = 124,
                lecSubjects = new List<Subject>()
                {
                    new Subject {SubjectID=04, SubjectName="Games",subjects = new List<LecturerSubject>()
                    {
                        new LecturerSubject {SubjectID=04, LecturerID =124 },
                    }
                }
                }
            });
                }
        }
    }

