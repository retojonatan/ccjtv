using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Api.ccjtv.Controllers
{
    public class AudiosController : Controller
    {
        // GET: Audios
        public ActionResult AgregarAudio()
        {
            return View();
        }
    }
}