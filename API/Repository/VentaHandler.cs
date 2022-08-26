using System.Data.SqlClient;

namespace MiPrimeraApi.Repository
{
    public class VentaHandler
    {
        
        public const string connectionstring = "Server=DESKTOP-HG0N7JJ;Database=SistemaGestion;Trusted_Connection=True";

        public static List<Venta> GetVenta()
        {
            List<Venta> ventas = new List<Venta>();
            using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                    "SELECT * FROM Venta", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                Venta venta = new Venta();
                                venta.Id = Convert.ToInt32(dataReader["Id"]);
                                venta.Comentarios = dataReader["Comentarios"].ToString();

                                ventas.Add(venta);
                            }
                        }
                    }

                    sqlConnection.Close();
                }
            }

            return ventas;
        }
        public static void Delete(Venta venta)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                {

                    string querydelete = "DELETE FROM Venta WHERE Id = @idVenta";

                    double id = 1;

                    SqlParameter parameter = new SqlParameter();

                    parameter.ParameterName = "idVenta";
                    parameter.Value = id;
                    parameter.SqlValue = System.Data.SqlDbType.BigInt;

                    using (SqlCommand sqlCommand = new SqlCommand(querydelete, sqlConnection))
                    {
                        sqlCommand.Parameters.Add(parameter);
                        int filasModificadas = sqlCommand.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
        }
        public static void InsertVenta(Venta venta)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                {
                    string queryVenta = "INSERT INTO Venta [SistemaGestion].[dbo].[Venta] (Id, Comentarios " +
                        "VALUES('7', 'Comentarios');";
                    
                    sqlConnection.Open();

                    using (SqlCommand sqlcommand = new SqlCommand(queryVenta, sqlConnection))
                    {
                        sqlcommand.ExecuteScalar();
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

