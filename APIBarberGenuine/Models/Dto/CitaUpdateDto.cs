using System.ComponentModel.DataAnnotations;

namespace APIBarberGenuine.Models.Dto

{
    public class CitaUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Service { get; set; }
        public DateTime Dates { get; set; }
        [Required]
        public int ClientId { get; set; }
    }
}
