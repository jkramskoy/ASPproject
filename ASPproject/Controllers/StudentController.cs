using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPproject.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Students = new List<string>
           {
               "Mark","Rosy","John"
           };

            ViewData["Students"] = new List<string>
                {
               "Mark","Rosy","John"
           };

            return View();
        }

        public string GetStudentName() {
            return "hello its a name method";
        }
    }
}
