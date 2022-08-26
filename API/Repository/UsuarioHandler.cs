using System.Data.SqlClient;

namespace MiPrimeraApi.Repository
{
    public static class UsuarioHandler
    {
        public const string connectionstring = "Server=DESKTOP-HG0N7JJ;Database=SistemaGestion;Trusted_Connection=True";
        public static List<Usuario> GetUsuarios()
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
        public static void Delete(Usuario usuario)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                {

                    string querydelete = "DELETE FROM Usuario WHERE Id = @idUsuario";

                    double id = 1;

                    SqlParameter parameter = new SqlParameter();

                    parameter.ParameterName = "idUsuario";
                    parameter.Value = id;
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
        public static void Update(Usuario usuario)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                {
                    string queryupdate = "UPDATE [SistemaGestion].[dbo].[Usuario]" +
                        "SET Nombre =@NuevoNombre" +
                        "Apellido =@NuevoApellido" +
                        "Contraseña=@NuevoContraseña" +
                        "NombreUsuario=@NuevoNombreUsuario" +
                        "Mail=@NuevoMail" +
                        "WHERE Id = Id";


                    SqlParameter parameterNombre = new SqlParameter();
                    parameterNombre.ParameterName = "NuevoNombre";
                    parameterNombre.Value = usuario.Nombre;
                    parameterNombre.SqlDbType = System.Data.SqlDbType.VarChar;

                    SqlParameter parameterApellido = new SqlParameter();
                    parameterApellido.ParameterName = "NuevoApellido";
                    parameterApellido.Value = usuario.Apellido;
                    parameterApellido.SqlDbType = System.Data.SqlDbType.VarChar;


                    SqlParameter parameterContraseña = new SqlParameter();
                    parameterContraseña.ParameterName = "NuevoContraseña";
                    parameterContraseña.Value = usuario.Contraseña;
                    parameterContraseña.SqlDbType = System.Data.SqlDbType.VarChar;


                    SqlParameter parameterNombreUsuario = new SqlParameter();
                    parameterNombreUsuario.ParameterName = "NuevoNombreUsuario";
                    parameterNombreUsuario.Value = usuario.NombreUsuario;
                    parameterNombreUsuario.SqlDbType = System.Data.SqlDbType.VarChar;


                    SqlParameter parameterMail = new SqlParameter();
                    parameterMail.ParameterName = "NuevoMail";
                    parameterMail.Value = usuario.Mail;
                    parameterMail.SqlDbType = System.Data.SqlDbType.VarChar;

                    SqlParameter parameterId = new SqlParameter();
                    parameterId.ParameterName = "Id";
                    parameterId.Value = usuario.Id;
                    parameterId.SqlDbType = System.Data.SqlDbType.VarChar;

                    sqlConnection.Open();

                    using (SqlCommand sqlcommand = new SqlCommand(queryupdate, sqlConnection))
                    {
                        sqlcommand.Parameters.Add((parameterNombre));
                        sqlcommand.Parameters.Add((parameterApellido));
                        sqlcommand.Parameters.Add((parameterContraseña));
                        sqlcommand.Parameters.Add((parameterNombreUsuario));
                        sqlcommand.Parameters.Add((parameterMail));
                        sqlcommand.Parameters.Add((parameterId));
                        sqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
        public static void Insert(Usuario usuario)
        {
            try
            {
               using (SqlConnection sqlConnection = new SqlConnection(connectionstring))
                {
                    string queryinsert = "INSERT INTO Usuario [SistemaGestion].[dbo].[Usuario] (Nombre, Apellido, NombreUsuario, Contraseña, Mail) " +
                        "VALUES('Ivan', 'Herrera Miranda', 'IvHerreraMiranda', 'Pass123', 'IvanHM@gmail.com');";

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
