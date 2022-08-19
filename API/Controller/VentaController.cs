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

        }
        [HttpDelete(Name ="DeleteVenta")]
        public void DeleteVenta([FromBody]int id)
        {

        }
        [HttpPut(Name ="PutVenta")]
        public void ModifyVenta([FromBody]PutVenta venta)
        {

        }
    }
}
