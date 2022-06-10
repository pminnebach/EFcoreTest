using System.ComponentModel.DataAnnotations;

namespace WpfApp2.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(128)]
        public string Name { get; set; }

        [Key]
        public int CategoryId { get; set; }
        
        [Required]
        [MaxLength(128)]
        public virtual Category Category { get; set; }
    }
}
