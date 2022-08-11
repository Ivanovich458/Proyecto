using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQL
{
    public class ProductosVendidosHandler : DbHandler
    {
        public const string connectionstring = "Server=DESKTOP-HG0N7JJ;Database=SistemaGestion;Trusted_Connection=True";

        public List<ProductoVendido> GetProductoVendidos()
        {
            List<ProductoVendido> productovendidos = new List<ProductoVendido>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                    "SELECT * FROM ProductoVendido", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                ProductoVendido productovendido = new ProductoVendido();
                                productovendido.Id = Convert.ToInt32(dataReader["Id"]);
                                productovendido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                productovendido.IdProducto = Convert.ToInt32(dataReader["IdProducto"]);
                                productovendido.IdVenta = Convert.ToInt32(dataReader["IdVenta"]);

                                productovendidos.Add(productovendido);
                            }
                        }
                    }

                    sqlConnection.Close();
                }
            }

            return productovendidos;
        }
    }
}

