using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rad301August2017.Models.AttendenceModel
{
    [Table("Lecturer")]
    public class Lecturer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LecturerID { get; set; }

        public string LecturerName { get; set; }

        public virtual ICollection<LecturerSubject> lecSubjects { get; set; }
    }
}