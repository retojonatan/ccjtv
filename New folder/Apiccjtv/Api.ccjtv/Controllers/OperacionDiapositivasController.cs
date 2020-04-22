using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.ccjtv.Controllers
{
    public class OperacionDiapositivasController : ApiController
    {
        [HttpGet]
        [Route("AgregarDiapositiva")]
        public bool AgregarDiapositiva()
        {
            return false;
        }

        [HttpGet]
        [Route("ModificarDiapositiva")]
        public void ModificarDiapositiva()
        {

        }

        [HttpGet]
        [Route("EliminarDiapositiva")]
        public bool EliminarDiapositiva()
        {
            return false;
        }
    }
}
