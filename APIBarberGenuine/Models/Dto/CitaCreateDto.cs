using System.ComponentModel.DataAnnotations;

namespace APIBarberGenuine.Models.Dto
{
    public class CitaCreateDto
    {
        [Required]
        public string? Service { get; set; }
        [Required]
        public DateTime Dates { get; set; }
        [Required]
        public int ClientId { get; set; }
    }
}
