using Api.ccjtv.Data;
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
        public bool AgregarImagen(string nombreImagen, string nombreAlbum, string ruta, string nivel, string tipo)
        {
            ImagenData imagen = new ImagenData();
            return imagen.AgregarImagen(nombreImagen, nombreAlbum, ruta, nivel, tipo);
        }

        [HttpGet]
        [Route("ModificarImagen")]
        public void ModificarImagen()
        {

        }

        [HttpGet]
        [Route("EliminarImagen")]
        public bool EliminarImagen(string nombreArchivo)
        {
            ImagenData audio = new ImagenData();
            return audio.EliminarImagen(nombreArchivo);
        }
    }
}
