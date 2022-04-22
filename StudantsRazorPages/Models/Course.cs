using System.Collections.Generic;

namespace StudantsRazorPages.Models
{
    public class Course
    {
        public Course()
        {
            Students = new List<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        ICollection<Student> Students { get; set; }
    }
}
