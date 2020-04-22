using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.ccjtv.Data
{
    public class VideoData
    {
        public bool AgregarVideo(string nombreVideo, string ruta, string nivel, string tipo)
        {
            using (var context = new ccjtvEntities())
            {
                bool guardoVideo;

                try
                {
                    Videos videoNuevo = new Videos();
                    videoNuevo.NombreVideo = nombreVideo;
                    videoNuevo.Ruta = ruta;
                    videoNuevo.Nivel = nivel;
                    videoNuevo.Tipo = tipo;

                    context.Videos.Add(videoNuevo);
                    guardoVideo = true;

                    context.SaveChanges();
                }
                catch (Exception)
                {
                    guardoVideo = false;
                }

                return guardoVideo;
            }
        }


        public bool EliminarVideo(string nombreVideo)
        {
            using (var context = new ccjtvEntities())
            {
                var data = context.Videos;
                bool eliminoVideo = false;

                foreach (var value in data)
                {
                    if (value.NombreVideo == nombreVideo)
                    {
                        context.Videos.Remove(value);
                        eliminoVideo = true;

                        break;
                    }
                }
                context.SaveChanges();

                return eliminoVideo;
            }
        }
    }
}