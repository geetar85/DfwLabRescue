using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DfwLabRescue.Web.Controllers
{
    public class ErrorController : BaseController
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult NotFound()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Forbidden()
        {
            return View();
        }
	}
}