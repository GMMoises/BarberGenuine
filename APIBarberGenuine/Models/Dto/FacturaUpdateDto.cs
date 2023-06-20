namespace APIBarberGenuine.Models.Dto
{
    public class FacturaUpdateDto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string? Description { get; set; }
        public int SoldUnits { get; set; }
        public decimal Total { get; set; }
    }
}
