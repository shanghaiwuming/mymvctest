using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApp1.Models
{
    public class Person
    {
        public int PersonID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Sex is required.")]
        public bool Sex { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}