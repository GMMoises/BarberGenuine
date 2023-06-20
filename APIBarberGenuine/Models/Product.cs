namespace APIBarberGenuine.Models
{
    public class Product
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //[Required]
        public string? NameProduct { get; set; }
        //[Required]
        public decimal? PriceUnit { get; set; }
       // [Required]
        public int UnitInStock { get; set; }
      //  [Required]
        public string? Providers { get; set; }
        public int FacturaId { get; set; }
        public Factura Factura { get; set; }
    }
}
