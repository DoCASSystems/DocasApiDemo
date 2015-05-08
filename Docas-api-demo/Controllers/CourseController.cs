using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using docas_api_demo.Utils;

namespace docas_api_demo.Controllers
{
    public class CourseController : BaseController
    {
        //
        // GET: /Course/
        public ActionResult Details(string id)
        {
            var course = DocasUtil.GetCourse(id);
            return View(course);
        }
	}
}