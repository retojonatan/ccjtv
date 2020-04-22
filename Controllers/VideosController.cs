using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Api.ccjtv.Controllers
{
    public class VideosController : Controller
    {
        // GET: Videos
        public ActionResult AgregarVideo()
        {
            return View();
        }
    }
}