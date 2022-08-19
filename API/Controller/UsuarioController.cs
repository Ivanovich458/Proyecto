using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Controllers.DTOS;

namespace MiPrimeraApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase 
    {
        [HttpGet(Name= "GetUsarios" ) ]
        public List<Usuario> GetUsuarios()
        {
            return Repository.UsuarioHandler.GetUsuarios();
        }
        [HttpPost(Name = "PostUsuario" ) ]
        public void CreateUsuario([FromBody] PostUsuario usuario)
        {
            
        }
        [HttpDelete(Name ="DeleteUsuario")]
        public void DeleteUsuario([FromBody]int id)
        {

        }
        [HttpPut(Name ="PutUsuario")]
        public void ModifyUsuario([FromBody] PutUsuario usuario)
        {

        }
    }
}
    

