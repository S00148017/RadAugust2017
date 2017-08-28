using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rad301August2017.Models.AttendenceModel
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }
        [Display(Name = "First Name")]
        public string StudentFName { get; set; }
        [Display(Name = "Last Name")]
        public string StudentLName { get; set; }

        public virtual ICollection<StudentSubject> studSubjects { get; set; }
    }
    
}
