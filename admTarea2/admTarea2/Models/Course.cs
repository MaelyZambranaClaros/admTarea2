using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace admTarea2.Models
{
    public enum CategoryTypeTitle
    { 
        Matematicas =10,
        Literatura = 20,
        Ciencias = 30,
        Historia = 40
    }
    public class Course
    {
        [Display(Name = "ID")]
        public int CourseID { get; set; }

        public CategoryTypeTitle Title { get; set; }
        
        [Range(1,20)]
        public int Credits { get; set; }
        public int DeparmentID { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}