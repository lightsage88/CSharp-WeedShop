using System;
namespace StoreDataBase.Models
{ 
    public class Product 
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public DateTime Created {get; set;}
        public decimal Price {get; set;}
        public string Type {get; set;}
    }
}