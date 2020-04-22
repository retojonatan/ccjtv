using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.ccjtv.Controllers
{
    public class OperacionVideosController : ApiController
    {
        [HttpGet]
        [Route("AgregarVideo")]
        public bool AgregarVideo()
        {
            return false;
        }

        [HttpGet]
        [Route("ModificarVideo")]
        public void ModificarVideo()
        {

        }

        [HttpGet]
        [Route("EliminarVideo")]
        public bool EliminarVideo()
        {
            return false;
        }
    }
}
