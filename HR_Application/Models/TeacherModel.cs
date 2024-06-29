using System.ComponentModel.DataAnnotations;

namespace HRApplication.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }

}
