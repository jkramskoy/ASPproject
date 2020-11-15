using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseRegistrationProgram.Models
{
    public class CoursesModel : IEquatable<CoursesModel>
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

        

        public bool Equals(CoursesModel other) {
            if (this.CourseID == other.CourseID && this.CourseNumber == other.CourseNumber
            && this.CourseName == other.CourseName && this.CourseDescription == other.CourseDescription)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
