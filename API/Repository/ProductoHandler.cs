using System.Data.SqlClient;

namespace MiPrimeraApi.Repository
{
    public class ProductoHandler
    {
        public const string connectionstring = "Server=DESKTOP-HG0N7JJ;Database=SistemaGestion;Trusted_Connection=True";
        public static List<Producto> GetProducto()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM USUARIO", sqlConnection))
                {
                    sqlConnection.Open();
                    {
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Producto producto = new Producto();

                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Descripciones = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToInt32(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToInt32(dataReader["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);

                                productos.Add(producto);
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return productos;
        }
    }
}

    