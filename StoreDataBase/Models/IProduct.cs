using System;

namespace StoreDataBase.Models
{
    public interface IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public decimal Price {get; set;}
        //TODO: could I use an enum for types? flower, concentrate, topicals, prerolls, etc?
        public string Type { get; set; }
    }
}