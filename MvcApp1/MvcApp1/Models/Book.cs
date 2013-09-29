using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApp1.Models
{
    public class Book
    {
        public int BookID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public int? PersonID { get; set; }

        public virtual Person Person { get; set; }
    }
}