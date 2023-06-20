namespace APIBarberGenuine.Models.Dto
{
    public class ClientUpdateDto
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string Phone { get; set; }
       // public ICollection<Cita> Citas { get; set; }

    }
}
