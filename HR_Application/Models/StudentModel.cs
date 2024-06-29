using System.ComponentModel.DataAnnotations;

namespace HRApplication.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int GradeLevel { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
    }

}