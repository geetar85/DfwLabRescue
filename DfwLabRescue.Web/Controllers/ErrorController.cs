using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DfwLabRescue.Web.Controllers
{
    public class ErrorController : BaseController
    {
        [Route("NotFound")]
        [HttpGet]
        public ActionResult NotFound()
        {
            return View();
        }
	}
}