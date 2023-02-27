﻿namespace FirelloProject.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string?Name { get; set; }
        public double? Price { get; set; }
        public int ? CategoryID { get; set; }
        public Category? Category { get; set; }
        public List<ProductImage>? ProductImages { get; set; }
    }
}
