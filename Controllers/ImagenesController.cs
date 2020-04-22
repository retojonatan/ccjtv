using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Api.ccjtv.Controllers
{
    public class ImagenesController : Controller
    {
        // GET: Imagenes
        public ActionResult AgregarImagen()
        {
            return View();
        }
    }
}