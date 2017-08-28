using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rad301August2017.Models.AttendenceModel
{
    public class AttendDBContext : DbContext
    {
            public DbSet<Student> Students { get; set; }
            public DbSet<Lecturer> Lecturers { get; set; }
            public DbSet<Subject> Subjects { get; set; }
            public DbSet<Attendence> Attendence { get; set; }
            public DbSet<StudentSubject> StudentSubjects { get; set; }
            public DbSet<LecturerSubject> LecturerSubjects { get; set; }


        public AttendDBContext() : base("DefaultConnection")
            {

            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                // modelBuilder can be used to explicitly specify what can be done as 
                // Data Annotations
                // This is taken into consideration when adding migrations
                //modelBuilder.Entity<Student>()
                //    .Property(r => r.Fname).HasColumnName("First_Name");

                //modelBuilder.Entity<Member>()
                //    .HasRequired(s => s.student);
                //modelBuilder.Entity<EventAtendance>()
                //    .HasRequired(e => e.clubEvent);
                //modelBuilder.Entity<EventAtendance>()
                //                .HasRequired(m => m.member);

                base.OnModelCreating(modelBuilder);
            }
            public static AttendDBContext Create()
            {
                return new AttendDBContext();
            }
        }
    }