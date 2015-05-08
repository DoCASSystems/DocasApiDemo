using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using docas_api_demo.Utils;

namespace docas_api_demo.Controllers
{
    public class LocationController : BaseController
    {

        public ActionResult Details(string id)
        {
            var location = DocasUtil.GetLocation(id);
            return View(location);
        }
	}
}