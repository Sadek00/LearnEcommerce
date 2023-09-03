using System.ComponentModel.DataAnnotations;

namespace learnEcommerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
