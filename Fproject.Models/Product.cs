using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace FProject.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Artist { get; set; }
        [Required]
        [Display(Name = "List Price")]
        [Range(1, 10000)]
        public double ListPrice { get; set; }
        [Required]
        [Display(Name = "Price for 1-10")]
        [Range(1, 10000)]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Price for 10+")]
        [Range(1, 10000)]
        public double Price10 { get; set; }
        [Required]
        [Display(Name = "Price for 25+")]
        [Range(1, 10000)]
        public double Price25 { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }

        [ValidateNever]
        public List<ProductImage> ProductImages { get; set; }




    }
}
