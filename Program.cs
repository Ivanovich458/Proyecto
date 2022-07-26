namespace Desafio1
{
    public class Inicio
    {
        static void Main(string[] args)
        {
            Usuario usuarioPredeterminado = new Usuario();

            Usuario usuario1 = new Usuario(45123584, "Ivan", "Herrera Miranda", "Ivanherrera1512@gmail.com", "Ivan1234", 458210584); 
            
            Producto ProductoPredeterminado = new Producto();

            Producto usuarioProducto1 = new Producto(45123585, "Soy Decripcion", 200, 450, 500, "Fredik123" );

            ProductoVendido ProductoVendidoPredeterminado = new ProductoVendido();

            ProductoVendido usuarioVendido1 = new ProductoVendido(45123555, 55555, 658, 876);

            Venta VentaPredeterminada = new Venta();

            Venta venta1 = new Venta(5564458,"Soy Un Comentario");


            Console.WriteLine(usuarioVendido1);
        }
    }
    public class Usuario
    {
        private double Id;
        private string Nombre;
        private string Apellido;
        private string Mail;
        private string NombreUsuario;
        private double Contraseña;
        public Usuario()
        {
            Id = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Mail = string.Empty;
            NombreUsuario = string.Empty;
            Contraseña = 0;
        }
        public Usuario(double Id,string Nombre,string Apellido,string Mail,string NombreUsuario,double Contraseña)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Mail = Mail;
            this.NombreUsuario = NombreUsuario;
            this.Contraseña = Contraseña;
        }
    }
    public class Producto
    {
        private double Id;
        private string Descripcion;
        private int Costo;
        private double PrecioVenta;
        private double Stocks;
        private string IdUsuario;
        
        public Producto()
        {
            Id = 0;
            Descripcion = string.Empty;
            Costo = 0;
            PrecioVenta = 0;
            Stocks = 0;
            IdUsuario = string.Empty;
        }
        public Producto(double Id, string Descripcion, int Costo, double PrecioVenta, double Stocks, string IdUsuario)
        {
            this.Id = Id;
            this.Descripcion = Descripcion;
            this.Costo = Costo;
            this.PrecioVenta = PrecioVenta;
            this.Stocks = Stocks;
            this.IdUsuario = IdUsuario;
        }
    }
    public class ProductoVendido
    {
        private double Id;
        private double IdProducto;
        private int Stocks;
        private double IdVenta;
        public ProductoVendido()
        {
            Id = 0;
            IdProducto = 0;
            Stocks= 0;
            IdVenta = 0;
        }
        public ProductoVendido(double Id, double IdProducto, int Stocks, double IdVenta)
        {
            this.Id = Id;
            this.IdProducto = IdProducto;
            this.Stocks = Stocks;
            this.IdVenta = IdVenta;
        }
    }
    public class Venta
    {
        private double Id;
        private string Comentarios;
        public Venta()
        {
            Id = 0;
            Comentarios = string.Empty;
        }
        public Venta(double Id,string Comentarios)
        {
            this.Id = Id;
            this.Comentarios = Comentarios;
        }
    }
}