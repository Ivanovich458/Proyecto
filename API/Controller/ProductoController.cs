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
        public void CreateProducto([FromBody] PostProducto producto) //PostProducto
        {
            Repository.ProductoHandler.CreateProducto(new Producto
                (
                Id = producto.Id,
                Descripciones = producto.Descripciones,
                Costo = producto.Costo,
                PrecioVenta = producto.PrecioVenta,
                Stock = producto.Stock,
                IdUsuario = producto.IdUsuario
                ));
        }
        [HttpDelete(Name = "DeleteProducto")]
        public void DeleteProducto([FromBody] int id) => Repository.ProductoHandler.DeleteProducto(id);
        [HttpPut(Name = "PutProducto")]
        public void ModifyProducto([FromBody] PutProducto producto) //PutProducto
        {
            try
            {
               
                Repository.ProductoHandler.ModifyProducto(new Producto
                (
                Id = producto.Id,
                Descripciones = producto.Descripciones,
                Costo = producto.Costo,
                PrecioVenta = producto.PrecioVenta,
                Stock = producto.Stock,
                IdUsuario = producto.IdUsuario
                ));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
