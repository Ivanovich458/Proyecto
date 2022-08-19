using System.Data.SqlClient;

namespace MiPrimeraApi.Repository
{
    public static class UsuarioHandler
    {
        public const string connectionstring = "Server=DESKTOP-HG0N7JJ;Database=SistemaGestion;Trusted_Connection=True";
        public static List <Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

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
                                Usuario usuario = new Usuario();
                                
                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                usuario.Nombre = dataReader["Nombre"].ToString();
                                usuario.Apellido = dataReader["Apellido"].ToString();
                                usuario.Contraseña = dataReader["Contraseña"].ToString();
                                usuario.Mail = dataReader["Mail"].ToString();
                                
                                usuarios.Add(usuario);
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return usuarios;
        }
    }
}
