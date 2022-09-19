using System;
using System.ComponentModel.DataAnnotations;

namespace Handler_Yapisi_deneme.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}