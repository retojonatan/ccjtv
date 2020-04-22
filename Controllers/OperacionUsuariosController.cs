using Api.ccjtv.Data;
using System.Web.Http;

namespace Api.ccjtv.Controllers
{
    [RoutePrefix("OperacionUsuarios")]
    public class OperacionUsuariosController : ApiController
    {
        [HttpGet]
        [Route("LoguearUsuario")]
        public bool LoguearUsuario(string username, string password)
        {

            UsuarioData dataUser = new UsuarioData();

            return dataUser.BuscarUsuario(username, password);
        }
    }
}
