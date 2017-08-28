using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rad301August2017.Models.AttendenceModel
{
    [Table("StudentSubject")]
    public class StudentSubject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public virtual Student student { get; set; }

        [Display(Name = "SubjectID")]
        public int SubjectID { get; set; }
        [ForeignKey("SubjectID")]
        public virtual Subject subject { get; set; }

        public virtual ICollection<Subject> subjects { get; set; }
    }
}