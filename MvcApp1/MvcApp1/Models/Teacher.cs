using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp1.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}