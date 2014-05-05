using DfwLabRescue.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace DfwLabRescue.Web.Controllers
{
    public class ContentController : BaseController
    {
        [Route("Content/{contentId}")]
        [HttpGet]
        public ActionResult ContentPage(string contentId)
        {
            var content = DB.AllContent.FirstOrDefault(c => c.ContentId == contentId);
            if (content == null)
                return HttpNotFound();

            return View(content);
        }


	}
}