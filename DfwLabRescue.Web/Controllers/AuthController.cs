using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DfwLabRescue.Web.Controllers
{
    public class AuthController : BaseController
    {
        
        [Route("Auth/Login")]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [Route("Auth/Login")]
        [HttpPost]
        public ActionResult Login(FormCollection form, string returnUrl)
        {
            var username = form.Get("username");
            var password = form.Get("password");

            if (username == "admin" && password == "password")
            {
                FormsAuthentication.SetAuthCookie(username, false);
                if (!string.IsNullOrWhiteSpace(returnUrl))
                    return Redirect(returnUrl);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
	}
}