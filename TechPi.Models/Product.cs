using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechPi.Models
{
	public class Product
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [DisplayName("Name")]
        [MaxLength(30)]
        public string ProductName { get; set; }
        [Required]
		[MaxLength(30)]
		[DisplayName("Product Code")]
		public string ProductCode { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0,1000000)]
        public decimal Price { get; set; }
		[Range(0,10000)]
		public int DisplayOrder { get; set; }
		[DisplayName("Description")]
		[MaxLength(1000)]
		public string ProductDescription { get; set; }
        public DateTime Created { get; set; }
        [Required]
		[DisplayName("Available")]
		public bool InStock { get; set; }
    }
}
