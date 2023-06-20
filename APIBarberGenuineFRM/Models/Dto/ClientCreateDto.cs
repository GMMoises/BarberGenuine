using System.ComponentModel.DataAnnotations;

namespace APIBarberGenuine.Models.Dto
{
    public class ClientCreateDto
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string Phone { get; set; }
        

    }
}
