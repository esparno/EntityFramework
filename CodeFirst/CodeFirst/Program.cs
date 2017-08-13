using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
    class Program
    {
        public class Course
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public CourseLevel Level { get; set; }
            public float FullPrice { get; set; }
            public Author Author { get; set; }
            public IList<Tag> Tags { get; set; }
        }

        public class Author
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IList<Course> Courses { get; set; }
        }

        public class Tag
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public IList<Course> Courses { get; set; }
        }

        public enum CourseLevel
        {
            Beginner = 1,
            Intermediate = 2,
            Advanced = 3
        }

        public class PlutoContext : DbContext
        {
            DbSet<Course> Courses { get; set; }
            DbSet<Author> Authors { get; set; }
            DbSet<Tag> Tags { get; set; }

            PlutoContext() : base("name=DefaultConnection")
            {

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
