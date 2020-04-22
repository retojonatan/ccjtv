using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.ccjtv.Data
{
    public class UsuarioData
    {
        public bool BuscarUsuario(string username, string password)
        {
            using (var context = new ccjtvEntities())
            {
                var data = context.Usuarios;
                bool encontrado = false;

                foreach (var value in data)
                {
                    if (value.Username == username && value.Password == password)
                    {
                        encontrado = true;
                    }                 
                }

                return encontrado;
            }
        }
    }
}