using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL
{
    public class DbHandler
    {
        public const string connectionstring = "Server=DESKTOP-HG0N7JJ;Database=SistemaGestion;Trusted_Connection=True";
    }
    public class Test
    {
        static void Main(string [] args)
        {
            ProductoHandler productohandler = new ProductoHandler();

            productohandler.GetProductos();

            UsuarioHandler usuariohandler = new UsuarioHandler();

            usuariohandler.GetUsuarios();

            ProductosVendidosHandler productosVendidoshandler = new ProductosVendidosHandler();

            productosVendidoshandler.GetProductoVendidos();

            VentaHandler ventahandler = new VentaHandler();

            ventahandler.GetVenta();
        }
    }
}
