using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rad301August2017.Models.AttendenceModel
{
    [Table("Lecturer Subject")]
    public class LecturerSubject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Display(Name = "SubjectID")]
        public int SubjectID { get; set; }
        [ForeignKey("SubjectID")]
        public virtual Subject subject { get; set; }
        public int LecturerID { get; set; }
        [ForeignKey("LecturerID")]
        public virtual Lecturer lecturer { get; set; }

        public virtual ICollection<Subject> subjects { get; set; }
    }
}