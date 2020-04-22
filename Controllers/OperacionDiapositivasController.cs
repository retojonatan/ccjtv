using Api.ccjtv.Data;
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
        public bool AgregarDiapositiva(string nombreDiapositiva, string ruta, string nivel, string tipo)
        {
            DiapositivaData diapositiva = new DiapositivaData();
            return diapositiva.AgregarDiapositiva(nombreDiapositiva, ruta, nivel, tipo);

        }

        [HttpGet]
        [Route("ModificarDiapositiva")]
        public void ModificarDiapositiva()
        {

        }

        [HttpGet]
        [Route("EliminarDiapositiva")]
        public bool EliminarDiapositiva(string nombreDiapositiva)
        {
            DiapositivaData diapositiva = new DiapositivaData();
            return diapositiva.EliminarDiapositiva(nombreDiapositiva);
        }
    }
}
