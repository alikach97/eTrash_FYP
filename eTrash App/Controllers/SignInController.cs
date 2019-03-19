using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eTrash_App.Controllers
{
    public class SignINController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Signin");
        }
        public ActionResult Signin()
        {
            return View("Signin");
        }
    }
}