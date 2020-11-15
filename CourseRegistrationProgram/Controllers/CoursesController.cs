
using Microsoft.AspNetCore.Mvc;


namespace CourseRegistrationProgram
{
    public class CoursesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = Helper.GetCourseData();
            return View(model);

        }

        // GET: /<controller>/id
        public IActionResult GetStudentsByCourse(int courseId)
        {
            int i = (int)courseId;
            var model = Helper.GetStudentsByCourse(i);
            return View(model);

        }
    }
}
