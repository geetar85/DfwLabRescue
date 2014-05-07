using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DfwLabRescue.Web.Controllers
{
    public class ErrorController : BaseController
    {
        [Route("Error")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [Route("Error/NotFound")]
        [HttpGet]
        public ActionResult NotFound()
        {
            return View();
        }

        [Route("Error/Forbidden")]
        [HttpGet]
        public ActionResult Forbidden()
        {
            return View();
        }
	}
}