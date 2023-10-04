using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(16, ErrorMessage = "Lenght must be less than 16 symbols.")]
        [MinLength(4, ErrorMessage = "Lenght must be more than 4 sybols.")]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [Required]
        [Range(1,100, ErrorMessage = "Display Order must be between 1-100.")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
