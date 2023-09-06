using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace learnEcommerce.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
