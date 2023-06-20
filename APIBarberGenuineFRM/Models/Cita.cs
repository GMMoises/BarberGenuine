namespace APIBarberGenuine.Models
{
    public class Cita
    {
        public int Id { get; set; }
        public string? Service { get; set; }
        public DateTime Dates { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
