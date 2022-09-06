namespace MiPrimeraApi
{
    public class Venta
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }

        public Venta(int Id, string Comentarios)
        {
            this.Id = 0;
            this.Comentarios = string.Empty;
        }
        
        
    }
}
