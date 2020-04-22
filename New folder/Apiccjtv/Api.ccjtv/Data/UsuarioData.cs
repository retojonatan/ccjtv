using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.ccjtv.Data
{
    public class UsuarioData
    {
        public Usuarios GetUsuario(string username, string password)
        {
            using (var context = new ccjtvEntities())
            {
                var data = context.Usuarios;
                Usuarios buscado = null;

                foreach (var value in data)
                {
                    if (value.Username == username && value.Password == password)
                    {
                        buscado = value;
                    }                 
                }

                return buscado;
            }
        }
    }
}