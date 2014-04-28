using DfwLabRescue.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DfwLabRescue.Web.Controllers
{
    public class DogsController : BaseController
    {

        [Route("Dogs/{id:int}/{name}")]
        public ActionResult Dog(int id, string name)
        {
            return View(DB.Dogs.FirstOrDefault(d => d.Id == id));
        }

        [Route("Dogs/Available")]
        public ActionResult Available()
        {
            ViewBag.Dogs = DB.Dogs.Where(d => d.AdoptionStatus == AdoptionStatus.Available).ToList();
            return View();
        }

        [Route("Dogs/ComingSoon")]
        public ActionResult ComingSoon()
        {
            ViewBag.Dogs = DB.Dogs.Where(d => d.AdoptionStatus == AdoptionStatus.ComingSoon).ToList();
            return View();
        }

        [Route("Dogs/PendingAdoption")]
        public ActionResult PendingAdoption()
        {
            ViewBag.Dogs = DB.Dogs.Where(d => d.AdoptionStatus == AdoptionStatus.AdoptionPending).ToList();
            return View();
        }

        [Route("Dogs/Adopted")]
        public ActionResult Adopted()
        {
            ViewBag.Dogs = DB.Dogs.Where(d => d.AdoptionStatus == AdoptionStatus.Adopted).ToList();
            return View();
        }
	}
}