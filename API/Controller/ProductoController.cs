using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Controllers.DTOS;

namespace MiPrimeraApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductoController : ControllerBase
    {
         [HttpGet(Name = "GetProducto")]
          public List<Producto> GetProducto()
          {
                return Repository.ProductoHandler.GetProducto();
          }
        [HttpPost(Name = "PostProducto")]
        public void CreateProducto([FromBody] PostProducto producto)
        {

        }
        [HttpDelete(Name = "DeleteProducto")]
        public void DeleteProducto([FromBody] int id)
        {

        }
        [HttpPut(Name = "PutProducto")]
        public void ModifyProducto([FromBody] PutProducto producto)
        {

        }
    }
}
