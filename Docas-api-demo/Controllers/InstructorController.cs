using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using docas_api_demo.Utils;

namespace docas_api_demo.Controllers
{
    public class InstructorController : BaseController
    {
        public ActionResult Index()
        {
            var instructors = DocasUtil.GetInstructors();
            return View(instructors);
        }


        public ActionResult Details(string id)
        {
            var instructor = DocasUtil.GetInstructor(id);
            return View(instructor);
        }
	}
}