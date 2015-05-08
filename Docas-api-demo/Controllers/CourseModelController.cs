using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using docas_api_demo.Utils;

namespace docas_api_demo.Controllers
{
    public class CourseModelController : BaseController
    {
        //
        // GET: /CourseModel/
        public ActionResult Details(string id)
        {
            var courseModel = DocasUtil.GetCourseModel(id);
            return View(courseModel);
        }
	}
}