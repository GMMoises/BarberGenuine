using System.ComponentModel.DataAnnotations;

namespace APIBarberGenuine.Models.Dto
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }
        
        [Required]
        public decimal? PriceUnit { get; set; }
        //[Required]
        public int UnitInStock { get; set; }
        
    }
}
