﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CourseRegistrationProgram.Controllers
{
    public class InstructorsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = Helper.GetInstructorData();
            return View(model);

        }
    }
}
