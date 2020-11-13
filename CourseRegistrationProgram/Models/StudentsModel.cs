using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseRegistrationProgram.Models
{
    public class StudentsModel
    {
        public StudentsModel()
        {

        }

        public int StudentID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public List<CoursesModel> Courses { set; get; }
    }
}
