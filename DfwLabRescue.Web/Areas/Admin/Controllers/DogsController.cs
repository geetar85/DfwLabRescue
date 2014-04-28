using DfwLabRescue.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DfwLabRescue.Web.Areas.Admin.Controllers
{
    public class DogsController : BaseAdminController
    {
        public ActionResult Index()
        {
            
            return View(DB.Dogs);
        }

        public ActionResult Add()
        {
            return View();
        }
	}
}