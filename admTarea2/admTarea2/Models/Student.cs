using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace admTarea2.Models
{
    public class Student
    {
       [Key]
        public int ID { get; set; }

        [StringLength(20,ErrorMessage ="The field must contain between {2} and {1} characters",MinimumLength =2)]
        [Required(ErrorMessage ="You must enter this field {0}")]
        public string LastName { get; set; }

        [StringLength(20, ErrorMessage = "The field must contain between {2} and {1} characters", MinimumLength = 2)]
        [Required(ErrorMessage = "You must enter this field {0}")]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
        public DateTime Enrollment { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}