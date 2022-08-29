using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Controllers.DTOS;

namespace MiPrimeraApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductoController : ControllerBase
    {
         [HttpGet(Name = "GetProducto")]
          public List <Producto> GetProducto()
          {
             return Repository.ProductoHandler.GetProducto();
          }
        [HttpPost(Name = "PostProducto")]
        public void CreateProducto([FromBody] Producto producto) //PostProducto
        {
            Repository.ProductoHandler.Insert(producto);
        }
        [HttpDelete(Name = "DeleteProducto")]
        public void DeleteProducto([FromBody] int id)
        {
            Repository.ProductoHandler.Delete(id);
        }
        [HttpPut(Name = "PutProducto")]
        public void ModifyProducto([FromBody] Producto producto) //PutProducto
        {
            Repository.ProductoHandler.Update(producto);
        }
    }
}
