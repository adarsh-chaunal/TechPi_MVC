using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechPi.Models
{
	public class Part
	{
		[Key]
		public long Id { get; set; }
		[Required]
		[DisplayName("Name")]
		[MaxLength(30)]
		public string PartName { get; set; }
		[Required]
		[MaxLength(30)]
		[DisplayName("Part Code")]
		public string PartCode { get; set; }
		[Required]
		[Column(TypeName = "decimal(18, 2)")]
		[Range(0, 1000000)]
		public decimal Price { get; set; }
		[Required]
		[Column(TypeName = "decimal(18, 2)")]
		[Range(0, 1000000)]
		[DisplayName("Price of for 50-100 parts")]
		public decimal Price50 { get; set; }
		[Required]
		[Column(TypeName = "decimal(18, 2)")]
		[Range(0, 1000000)]
		[DisplayName("Price for 100+ parts")]
		public decimal Price100 { get; set; }
		[Required]
		[DisplayName("Product Name")]
		[MaxLength(30)]
		public string Product { get; set; }
        [Required]
		[DisplayName("Available")]
		public bool InStock { get; set; }
	}
}
