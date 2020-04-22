using Api.ccjtv.Data;
using System.Web.Http;

namespace Api.ccjtv.Controllers
{
    public class OperacionAudiosController : ApiController
    {
        [HttpGet]
        [Route("AgregarAudio")]
        public bool AgregarAudio(string nombreArchivo, string NombreAlbum, string ruta, string nivel, string tipo)
        {
            AudioData audio = new AudioData();
            return audio.AgregarAudio(nombreArchivo, NombreAlbum, ruta, nivel, tipo);
        }

        [HttpGet]
        [Route("ModificarAudio")]
        public void ModificarAudio()
        {

        }

        [HttpGet]
        [Route("EliminarAudio")]
        public bool EliminarAudio(string nombreArchivo)
        {
            AudioData audio = new AudioData();
            return audio.EliminarAudio(nombreArchivo);
        }
    }
}
