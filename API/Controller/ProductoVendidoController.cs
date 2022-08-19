using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Controllers.DTOS;

namespace MiPrimeraApi.Controllers

{
        [ApiController]
        [Route("[Controller]")]
    public class ProductoVendidoController : ControllerBase
    {
            [HttpGet(Name = "GetProductoVendido")]
            public List<ProductoVendido> GetProductoVendidos()
            {
                return Repository.ProductoVendidoHandler.GetProductoVendidos();
            }
            [HttpPost(Name = "PostProductoVendido")]
            public void CreateProductoVendido([FromBody] PostProductoVendido productovendido)
            {

            }
            [HttpDelete(Name = "DeleteProductoVendido")]
            public void DeleteProductoVendido([FromBody] int id)
            {

            }
            [HttpPut(Name = "PutProductoVendido")]
            public void ModifyProductoVendido([FromBody] PutProductoVendido productovendido)
            {

            }
        }
    }

