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
        public void CreateUsuario([FromBody] PostUsuario usuario) //PostUsuario
        {
            try
            {
            return UsuarioHandler.CreateUsuario(new Usuario
                (
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                NombreUsuario = usuario.NombreUsuario,
                Contraseña = usuario.Contraseña,
                Mail = usuario.Mail));

            }
           catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        [HttpDelete(Name = "DeleteUsuario")]
        public void DeleteUsuario([FromBody] int id) => UsuarioHandler.DeleteUsuario(id);
        
        [HttpPut(Name ="PutUsuario")]
        public void ModifyUsuario([FromBody] PutUsuario usuario) //PutUsuario
        {
            try
            {
            return UsuarioHandler.ModifyUsuario(new Usuario
                (
                Id = usuario.Id, 
                Nombre = usuario.Nombre, 
                Apellido = usuario.Apellido, 
                NombreUsuario = usuario.NombreUsuario, 
                Contraseña = usuario.Contraseña, 
                Mail = usuario.Mail
                ));

            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
