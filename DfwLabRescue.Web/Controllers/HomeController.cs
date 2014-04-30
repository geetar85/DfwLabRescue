using DfwLabRescue.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DfwLabRescue.Web.Controllers
{
    public class HomeController : BaseController
    {
        [Route("")]
        [HttpGet]
        public ActionResult Index()
        {
            var adoptedCount = DB.Dogs.Count(d => d.AdoptionStatus == AdoptionStatus.Adopted && d.AdoptionDate.HasValue && d.AdoptionDate.Value.Year == DateTime.Now.Year);
            var recentAvailableDogs = DB.Dogs.Where(d => d.AdoptionStatus == AdoptionStatus.Available).OrderByDescending(d => d.DateCreated).Take(4).ToList();
            ViewBag.AvailableDogs = recentAvailableDogs;
            ViewBag.AdoptedCount = adoptedCount;

            return View();
        }
	}
}