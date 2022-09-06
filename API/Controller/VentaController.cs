using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Controllers.DTOS;

namespace MiPrimeraApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name ="GetVenta")]
        public List<Venta> GetVenta()
        {
            return Repository.VentaHandler.GetVenta();
        }
        [HttpPost(Name ="PostVenta")]
        public void CreateVenta([FromBody] PostVenta venta)
        {
            try
            {
                Repository.VentaHandler.CreateVenta(new Venta
                    (
                    Id = venta.Id,
                    Comentario = venta.Comentarios
                    )); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [HttpDelete(Name = "DeleteVenta")]
        public void DeleteVenta([FromBody] int id) => Repository.VentaHandler.DeleteVenta(id);
    }
