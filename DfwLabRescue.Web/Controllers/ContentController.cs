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

        [Route("Content/upload")]
        [HttpPost]
        public ActionResult Upload(IEnumerable<HttpPostedFileBase> files)
        {
            var fileList = new List<FileResult>();
            foreach (var file in files)
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                    file.SaveAs(path);
                    fileList.Add(new FileResult { name = file.FileName, size = file.ContentLength, url = Url.Content("~/App_Data/uploads/" + fileName) });
                }
            }
            return Json(fileList);
        }


	}


    public class FileResult
    {
        public string name { get; set; }
        public double size { get; set; }
        public string url { get; set; }
    }
}