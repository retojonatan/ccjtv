using Api.ccjtv.Data;
using System.Web.Http;

namespace Api.ccjtv.Controllers
{
    public class OperacionUsuariosController : ApiController
    {
        [HttpGet]
        [Route("LoguearUsuario")]
        public Usuarios LoguearUsuario(string username, string password)
        {
            UsuarioData dataUser = new UsuarioData();

            return dataUser.GetUsuario(username,password);
        }
    }
}
