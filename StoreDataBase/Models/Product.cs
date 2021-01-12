using System;
using StoreDataBase.Models;

namespace StoreDataBase.Models
{ 
    public class Product : IProduct
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public DateTime Created {get; set;}
        public decimal Price {get; set;}
        public string Type {get; set;}
    }
}