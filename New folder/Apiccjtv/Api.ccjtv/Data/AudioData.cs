using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.ccjtv.Data
{
    public class AudioData
    {
        public bool AgregarAudio(string nombreArchivo, string NombreAlbum, string ruta, string nivel, string tipo)
        {
            using (var context = new ccjtvEntities())
            {
                bool guardoAudio;

                try
                {
                    Audios audioNuevo = new Audios();
                    audioNuevo.NombreArchivo = nombreArchivo;
                    audioNuevo.NombreAlbum = NombreAlbum;
                    audioNuevo.Ruta = ruta;
                    audioNuevo.Nivel = nivel;
                    audioNuevo.Tipo = tipo;

                    context.Audios.Add(audioNuevo);
                    guardoAudio = true;

                    context.SaveChanges();   
                }
                catch (Exception)
                {
                    guardoAudio = false;
                }

                return guardoAudio;
            }
        }

        public bool EliminarAudio(string nombreArchivo)
        {
            using (var context = new ccjtvEntities())
            {
                var data = context.Audios;
                bool eliminoAudio = false;

                foreach (var value in data)
                {
                    if (value.NombreArchivo == nombreArchivo)
                    {
                        context.Audios.Remove(value);
                        eliminoAudio = true;

                        break;
                    }                   
                }
                context.SaveChanges();

                return eliminoAudio;
            }
        }
    }
}