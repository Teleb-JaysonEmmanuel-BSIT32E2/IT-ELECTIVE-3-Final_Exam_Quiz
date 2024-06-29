using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRApplication.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceID { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        public int CourseID { get; set; }
        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }
    }

}
