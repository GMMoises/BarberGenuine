using System.ComponentModel.DataAnnotations;

namespace APIBarberGenuine.Models.Dto
{
    public class CitaDto
    {
        public int Id { get; set; }
        [Required]
        public string? Service { get; set; }
        [Required]
        public DateTime Dates { get; set; }
        public int ClientId { get; set; }
    }
}
