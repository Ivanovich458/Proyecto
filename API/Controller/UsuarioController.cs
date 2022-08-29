using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Controllers.DTOS;
using MiPrimeraApi.Repository;

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
        public void CreateUsuario([FromBody] Usuario usuario) //PostUsuario
        {
             UsuarioHandler.Insert(usuario);
        }
        [HttpDelete(Name ="DeleteUsuario")]
        public void DeleteUsuario([FromBody] int id)
        {
            UsuarioHandler.Delete(id);
        }
        [HttpPut(Name ="PutUsuario")]
        public void ModifyUsuario([FromBody] Usuario usuario) //PutUsuario
        {
            UsuarioHandler.Update(usuario);
        }
    }
}
    

