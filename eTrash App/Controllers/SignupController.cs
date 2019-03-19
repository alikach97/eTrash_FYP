using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTrash_App.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        public ActionResult Index()
        {
            return View("Signup");
        }
        public ActionResult Signup()
        {
            return View("Signup");
        }
    }
}