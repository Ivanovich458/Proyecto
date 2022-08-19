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
    }
}

