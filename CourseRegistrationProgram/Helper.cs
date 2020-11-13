using System;
using System.Collections.Generic;
using CourseRegistrationProgram.Models;

namespace CourseRegistrationProgram

{
    // including sample data to our tables
    public static class Helper
    {
        public static List<StudentsModel> GetStudentsData()
        {

            var list = new List<StudentsModel>
            {
                new StudentsModel(){ FirstName = "Jone",LastName = "Simson",EmailAddress = "jone@gmail.com",PhoneNumber = "204-530-7765" },
                new StudentsModel(){ FirstName = "Lesly",LastName = "Kery",EmailAddress = "lesly@gmail.com" ,PhoneNumber = "203-654-9985"},
                new StudentsModel(){ FirstName = "Mark",LastName = "Lord",EmailAddress = "mark@gmail.com",PhoneNumber = "203-543-7654" },
                new StudentsModel(){ FirstName = "Tom",LastName = "Morys",EmailAddress = "tom@gmail.com" ,PhoneNumber = "403-876-6543"},
                new StudentsModel(){ FirstName = "More",LastName = "Kegen",EmailAddress = "more@gmail.com",PhoneNumber = "403-543-8760"}
            };

            return list;
        }

        public static List<CoursesModel> GetCourseData()
        {
            var list = new List<CoursesModel>
            {
                new CoursesModel(){ CourseNumber = "1",CourseName = "Accountant",CourseDescription = "Full stuck accountant" },
                new CoursesModel(){ CourseNumber = "2",CourseName = "Project Manager",CourseDescription = "Learn how to planning, executing, monitoring, controlling and closing projects." },
                new CoursesModel(){ CourseNumber = "3",CourseName = "Front End Developer",CourseDescription = "Practice of converting data to a graphical interface, through the use of HTML, CSS, and JavaScript." },
                new CoursesModel(){ CourseNumber = "4",CourseName = "Dental assistant",CourseDescription = "This program provides the skills and knowledge required to assist the dentist" },
            };

            return list;
        }

        public static List<InstructorsModel> GetInstructorData()
        {
            var list = new List<InstructorsModel>
            {
                new InstructorsModel(){ FirstName = "Lary", LastName = "Lopster", EmailAddress = "lary@gmail.com", Course = "Accountant" },
                new InstructorsModel(){ FirstName = "Mark", LastName = "Moren", EmailAddress = "mark@gmail.com", Course = "Project Manager" },
                new InstructorsModel(){ FirstName = "Sam", LastName = "Keg", EmailAddress = "sam@gmail.com", Course = "Front End Developer" },
                new InstructorsModel(){ FirstName = "Jerry", LastName = "Zeep", EmailAddress = "jerry@gmail.com", Course = "Dental assistant" },
            };
 
            return list;
        }
           
    }
}
