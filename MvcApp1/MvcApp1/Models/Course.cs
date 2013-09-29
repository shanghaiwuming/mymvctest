using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApp1.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

    }
}