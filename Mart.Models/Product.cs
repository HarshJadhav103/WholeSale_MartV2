using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mart.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        [Required]
        public int ProductNumber { get; set; }
        [Required]
        public string VedorName { get; set; }
        [Required]
        [Display(Name = "Original Price")]
        [Range(1,10000)]
        public double OriginalPrice { get; set; }
        [Required]
        [Display(Name = "Price for 1-9")]
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
        [ValidateNever]
        public string ImageUrl { get; set; }

        //Adding Foregin Key Relation 
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
    }
}
