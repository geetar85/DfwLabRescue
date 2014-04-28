using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DfwLabRescue.Web.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.NavPartial = "_BaseNav";
            ViewBag.FooterPartial = "_BaseFooter";
            base.OnActionExecuting(filterContext);
        }
	}
}