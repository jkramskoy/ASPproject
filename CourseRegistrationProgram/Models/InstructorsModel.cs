using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseRegistrationProgram.Models
{
    public class InstructorsModel
    {
        public InstructorsModel()
        {
        }

        public int InstructorId { get; set; }
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
        public string Course { get; set; }

        public int CourseID { set; get; }
        public CoursesModel Courses { set; get; }


    }
}
