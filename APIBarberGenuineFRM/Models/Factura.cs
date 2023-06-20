namespace APIBarberGenuine.Models
{
    public class Factura
    {
        public Factura()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string? Description { get; set; }
        public int SoldUnits { get; set; }
        public decimal Total { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
