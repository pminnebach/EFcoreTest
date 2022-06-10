using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace WpfApp2.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(128)]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; private set; } = new ObservableCollection<Product>();
    }
}
