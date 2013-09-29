using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApp1.Models;
namespace MvcApp1.ViewModel
{
    public class PersonData
    {
        public IEnumerable<Person> Persons { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}