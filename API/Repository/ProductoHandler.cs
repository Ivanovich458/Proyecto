using MiPrimeraApi.Controllers.DTOS;
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
            public static void DeleteProducto(int id)
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                    {

                        string querydelete = "DELETE FROM Producto WHERE Id = @idProducto";

                        double idProducto = 1;

                        SqlParameter parameter = new SqlParameter();

                        parameter.ParameterName = "idProducto";
                        parameter.Value = idProducto;
                        parameter.SqlValue = System.Data.SqlDbType.BigInt;

                        using (SqlCommand sqlCommand = new SqlCommand(querydelete, sqlConnection))
                        {
                            sqlCommand.Parameters.Add(parameter);
                            int filasModificadas = sqlCommand.ExecuteNonQuery();
                        }

                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            public static void ModifyProducto( PutProducto producto)
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                    {
                        string queryupdate = "UPDATE [SistemaGestion].[dbo].[Producto]" +
                            "SET Descripcion =@NuevaDescripciones" +
                            "Costo =@NuevoCosto" +
                            "PrecioVenta=@NuevoPrecioVenta" +
                            "Stock=@NuevoStock" +
                            "IdUsuario=@NuevoIdUsuario" +
                            "WHERE Id = Id";


                        SqlParameter parameterDescripcion = new SqlParameter();
                        parameterDescripcion.ParameterName = "NuevaDescripciones";
                        parameterDescripcion.Value = producto.Descripciones;
                        parameterDescripcion.SqlDbType = System.Data.SqlDbType.VarChar;

                        SqlParameter parameterCosto = new SqlParameter();
                        parameterCosto.ParameterName = "NuevoCosto";
                        parameterCosto.Value = producto.Costo;
                        parameterCosto.SqlDbType = System.Data.SqlDbType.Int;


                        SqlParameter parameterPrecioVenta = new SqlParameter();
                        parameterPrecioVenta.ParameterName = "NuevoPrecioVenta";
                        parameterPrecioVenta.Value = producto.PrecioVenta;
                        parameterPrecioVenta.SqlDbType = System.Data.SqlDbType.Int;


                        SqlParameter parameterStock = new SqlParameter();
                        parameterStock.ParameterName = "NuevoStock";
                        parameterStock.Value = producto.Stock;
                        parameterStock.SqlDbType = System.Data.SqlDbType.Int;


                        SqlParameter parameterIdUsuario = new SqlParameter();
                        parameterIdUsuario.ParameterName = "NuevoIdUsuario";
                        parameterIdUsuario.Value = producto.IdUsuario;
                        parameterIdUsuario.SqlDbType = System.Data.SqlDbType.VarChar;

                        SqlParameter parameterId = new SqlParameter();
                        parameterId.ParameterName = "Id";
                        parameterId.Value = producto.Id;
                        parameterId.SqlDbType = System.Data.SqlDbType.VarChar;

                        sqlConnection.Open();

                        using (SqlCommand sqlcommand = new SqlCommand(queryupdate, sqlConnection))
                        {
                            sqlcommand.Parameters.Add((parameterDescripcion));
                            sqlcommand.Parameters.Add((parameterCosto));
                            sqlcommand.Parameters.Add((parameterPrecioVenta));
                            sqlcommand.Parameters.Add((parameterStock));
                            sqlcommand.Parameters.Add((parameterIdUsuario));
                            sqlcommand.Parameters.Add((parameterId));
                            sqlcommand.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                { Console.WriteLine(ex.Message); }
            }
            public static void CreateProducto(PostProducto producto)
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                    {
                        string queryinsert = "INSERT INTO Producto [SistemaGestion].[dbo].[Producto] (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) " +
                            "VALUES('Campera de Cuero', '3.000', '3.500', '30', '10');";

                        sqlConnection.Open();

                        using (SqlCommand sqlcommand = new SqlCommand(queryinsert, sqlConnection))
                        {
                            sqlcommand.ExecuteScalar();
                        }
                        sqlConnection.Close();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
    }
        
}


    
    
