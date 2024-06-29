using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HRApplication.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }

        public int TeacherID { get; set; }
        [ForeignKey("TeacherID")]
        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
    }

}
