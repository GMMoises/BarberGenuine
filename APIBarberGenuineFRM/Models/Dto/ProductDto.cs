using System.ComponentModel.DataAnnotations;

namespace APIBarberGenuine.Models.Dto
{
    public class ProductDto
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? NameProduct { get; set; }
        [Required]
        public decimal? PriceUnit { get; set; }
        //[Required]
        public int UnitInStock { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Providers { get; set; }
        [Required]
        public int FacturaId { get; set; }
    }
}
