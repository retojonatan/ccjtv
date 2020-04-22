using Api.ccjtv.Data;
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
        public bool AgregarVideo(string nombreVideo, string ruta, string nivel, string tipo)
        {
            VideoData video = new VideoData();
            return video.AgregarVideo(nombreVideo, ruta, nivel, tipo);
        }

        [HttpGet]
        [Route("ModificarVideo")]
        public void ModificarVideo()
        {

        }

        [HttpGet]
        [Route("EliminarVideo")]
        public bool EliminarVideo(string nombreVideo)
        {
            VideoData video = new VideoData();
            return video.EliminarVideo(nombreVideo);
        }
    }
}
