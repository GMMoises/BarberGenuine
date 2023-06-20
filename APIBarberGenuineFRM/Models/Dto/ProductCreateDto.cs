using System.ComponentModel.DataAnnotations;

namespace APIBarberGenuine.Models.Dto
{
    public class ProductCreateDto
    {
        [Required]
        [MaxLength(50)]
        public string? NameProduct { get; set; }
        [Required]
        public decimal? PriceUnit { get; set; }
       
        public int UnitInStock { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Providers { get; set; }
    }
}
