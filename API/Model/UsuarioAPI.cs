
public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Contraseña { get; set; }
    public string NombreUsuario { get; set; }
    public double Mail { get; set; }


    public Usuario()
    {
        this.Id = 0;
        this.Nombre = String.Empty;
        this.Apellido = String.Empty;
        this.NombreUsuario = String.Empty;
        this.Contraseña = String.Empty;
        this.Mail = 0;
    }

    public Usuario(int id,
                   string Nombre,
                   string Apellido,
                   string NombreUsuario,
                   string Contraseña,
                   double Mail)
    {
        this.Id = id;
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.NombreUsuario = NombreUsuario;
        this.Contraseña = Contraseña;
        this.Mail = Mail;
    }


}
