using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MvcApp1.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace MvcApp1.DAL
{
    public class UniversityContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}