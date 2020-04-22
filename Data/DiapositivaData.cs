using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.ccjtv.Data
{
    public class DiapositivaData
    {
        public bool AgregarDiapositiva(string nombreDiapositiva, string ruta, string nivel, string tipo)
        {
            using (var context = new ccjtvEntities())
            {
                bool guardoDiapositiva;

                try
                {
                    Diapositivas diapositivaNuevo = new Diapositivas();
                    diapositivaNuevo.NombreDiapositiva = nombreDiapositiva;
                    diapositivaNuevo.Ruta = ruta;
                    diapositivaNuevo.Nivel = nivel;
                    diapositivaNuevo.Tipo = tipo;

                    context.Diapositivas.Add(diapositivaNuevo);
                    guardoDiapositiva = true;

                    context.SaveChanges();
                }
                catch (Exception)
                {
                    guardoDiapositiva = false;
                }

                return guardoDiapositiva;
            }
        }


        public bool EliminarDiapositiva(string nombreDiapositiva)
        {
            using (var context = new ccjtvEntities())
            {
                var data = context.Diapositivas;
                bool eliminoDiapositiva= false;

                foreach (var value in data)
                {
                    if (value.NombreDiapositiva == nombreDiapositiva)
                    {
                        context.Diapositivas.Remove(value);
                        eliminoDiapositiva = true;

                        break;
                    }
                }
                context.SaveChanges();

                return eliminoDiapositiva;
            }
        }
    }
}