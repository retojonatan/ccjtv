using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.ccjtv.Data
{
    public class ImagenData
    {
        public bool AgregarImagen(string nombreArchivo, string NombreAlbum, string ruta, string nivel, string tipo)
        {
            using (var context = new ccjtvEntities())
            {
                bool guardoImagen;

                try
                {
                    Imagenes imagenNueva = new Imagenes();
                    imagenNueva.NombreArchivo = nombreArchivo;
                    imagenNueva.NombreAlbum = NombreAlbum;
                    imagenNueva.Ruta = ruta;
                    imagenNueva.Nivel = nivel;
                    imagenNueva.Tipo = tipo;

                    context.Imagenes.Add(imagenNueva);
                    guardoImagen = true;

                    context.SaveChanges();
                }
                catch (Exception)
                {
                    guardoImagen = false;
                }

                return guardoImagen;
            }    
        }

        public bool EliminarImagen(string nombreArchivo)
        {
            using (var context = new ccjtvEntities())
            {
                var data = context.Imagenes;
                bool eliminoImagen = false;

                foreach (var value in data)
                {
                    if (value.NombreArchivo == nombreArchivo)
                    {
                        context.Imagenes.Remove(value);
                        eliminoImagen = true;

                        break;
                    }
                }
                context.SaveChanges();

                return eliminoImagen;
            }
        }
    }
}