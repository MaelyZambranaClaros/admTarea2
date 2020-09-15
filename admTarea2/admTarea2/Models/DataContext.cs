using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace admTarea2.Models
{
    public class DataContext:DbContext
    {
        public DataContext(): base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<admTarea2.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<admTarea2.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<admTarea2.Models.Enrollment> Enrollments { get; set; }
    }
}