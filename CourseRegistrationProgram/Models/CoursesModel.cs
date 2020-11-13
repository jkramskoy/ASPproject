using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseRegistrationProgram.Models
{
    public class CoursesModel
    {
        public CoursesModel()
        {
        }

        public int CourseID { get; set; }
        public string CourseNumber { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string CourseName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string CourseDescription { get; set; }

        public List<InstructorsModel> Courses { set; get; }
        public List<StudentsModel> Students { set; get; }


    }
}
