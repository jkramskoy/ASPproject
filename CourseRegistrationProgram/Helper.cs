using System;
using System.Collections.Generic;
using CourseRegistrationProgram.Models;

namespace CourseRegistrationProgram

{
    // including sample data to our tables
    public static class Helper
    {

        public static List<CoursesModel> GetCourseData()
        {
            var list = new List<CoursesModel>
            {
                new CoursesModel(){ CourseID=1, CourseNumber = "150",CourseName = "Accountant",CourseDescription = "Full stuck accountant" },
                new CoursesModel(){ CourseID=2,CourseNumber = "260",CourseName = "Project Manager",CourseDescription = "Learn how to planning, executing, monitoring, controlling and closing projects." },
                new CoursesModel(){ CourseID=3,CourseNumber = "320",CourseName = "Front End Developer",CourseDescription = "Practice of converting data to a graphical interface, through the use of HTML, CSS, and JavaScript." },
                new CoursesModel(){ CourseID=4,CourseNumber = "480",CourseName = "Dental assistant",CourseDescription = "This program provides the skills and knowledge required to assist the dentist" },
            };

            return list;
        }

        public static List<StudentsModel> GetStudentsData()
        {

            var list = new List<StudentsModel>
            {
                new StudentsModel(){ FirstName = "Jone",LastName = "Simson",EmailAddress = "jone@gmail.com",PhoneNumber = "204-530-7765" ,
                                     CoursesList = new List<CoursesModel>{GetCourseData().Find(course => course.CourseID == 1)} },
                new StudentsModel(){ FirstName = "Lesly",LastName = "Kery",EmailAddress = "lesly@gmail.com" ,PhoneNumber = "203-654-9985",
                                     CoursesList = new List<CoursesModel>{GetCourseData().Find(coutse => coutse.CourseID ==3)} },
                new StudentsModel(){ FirstName = "Mark",LastName = "Lord",EmailAddress = "mark@gmail.com",PhoneNumber = "203-543-7654" ,
                                     CoursesList = new List<CoursesModel>{GetCourseData().Find(coutse => coutse.CourseID ==4)} },
                new StudentsModel(){ FirstName = "Tom",LastName = "Morys",EmailAddress = "tom@gmail.com" ,PhoneNumber = "403-876-6543",
                                     CoursesList = new List<CoursesModel>{ GetCourseData().Find(course => course.CourseID == 1), GetCourseData().Find(course => course.CourseID ==2) } },
                new StudentsModel(){ FirstName = "More",LastName = "Kegen",EmailAddress = "more@gmail.com",PhoneNumber = "403-543-8760",
                                     CoursesList = new List<CoursesModel>{ GetCourseData().Find(course => course.CourseID == 1), GetCourseData().Find(course => course.CourseID ==2) } }
            };

            return list;
        }

      

        public static List<InstructorsModel> GetInstructorData()
        {
            var list = new List<InstructorsModel>
            {
                new InstructorsModel(){ FirstName = "Lary", LastName = "Lopster", EmailAddress = "lary@gmail.com", Course = "Accountant" },
                new InstructorsModel(){ FirstName = "Mark", LastName = "Moren", EmailAddress = "markus@gmail.com", Course = "Project Manager" },
                new InstructorsModel(){ FirstName = "Sam", LastName = "Keg", EmailAddress = "sam@gmail.com", Course = "Front End Developer" },
                new InstructorsModel(){ FirstName = "Jerry", LastName = "Zeep", EmailAddress = "jerry@gmail.com", Course = "Dental assistant" },
            };

            return list;
        }

        public static List<StudentsModel> GetStudentsByCourse(int courseId) {


            var coursemodel = GetCourseData().Find(course => course.CourseID == courseId);
            var students = GetStudentsData()
                            .FindAll(elem => elem.CoursesList.Contains(coursemodel));

            return students;
        }

    }
}
