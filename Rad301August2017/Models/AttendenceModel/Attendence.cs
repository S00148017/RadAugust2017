using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rad301August2017.Models.AttendenceModel
{
    public class Attendence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendenceID { get; set; }
        public DateTime AttendenceDate { get; set; }
        public int SubjectID { get; set; }
        [ForeignKey("SubjectID")]
        public virtual Subject subject { get; set; }
        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public virtual Student student { get; set; }
        
    }
}