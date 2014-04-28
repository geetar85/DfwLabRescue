using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DfwLabRescue.Web.Controllers
{
    public class ApplicationsController : BaseController
    {
        [Route("Applications/Adoption")]
        [HttpGet]
        public ActionResult Adoption()
        {
            return View();
        }

        [Route("Applications/Adoption")]
        [HttpPost]
        public ActionResult Adoption(FormCollection form)
        {
            return View();
        }

        [Route("Applications/Foster")]
        [HttpGet]
        public ActionResult Foster()
        {
            return View();
        }

        [Route("Applications/Volunteer")]
        [HttpGet]
        public ActionResult Volunteer()
        {
            return View();
        }
	}
}