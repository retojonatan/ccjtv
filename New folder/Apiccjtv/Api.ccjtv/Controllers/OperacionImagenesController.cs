using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.ccjtv.Controllers
{
    public class OperacionImagenesController : ApiController
    {
        [HttpGet]
        [Route("AgregarImagen")]
        public bool AgregarImagen()
        {
            return false;
        }

        [HttpGet]
        [Route("ModificarImagen")]
        public void ModificarImagen()
        {

        }

        [HttpGet]
        [Route("EliminarImagen")]
        public bool EliminarImagen()
        {
            return false;
        }
    }
}
