﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceDatabase.Database.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; } 
        public string Description { get; set; }
        public byte[] HeroImage { get; set; }
        public string HeroTitle { get; set; }
        public virtual List<ProductImage> Images { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual List<ProductSize> Sizes { get; set; } 
        public virtual ProductType ProductType { get; set; }
        public decimal Price { get; set; }
    }
}