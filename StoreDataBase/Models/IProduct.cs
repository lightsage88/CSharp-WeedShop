using System;
using StoreDataBase.Models;

namespace StoreDataBase.Models
{
    public interface IProduct
    {
         int Id { get; set; }
         string Name { get; set; }
         DateTime Created { get; set; }
         decimal Price {get; set;}
        //TODO: could I use an enum for types? flower, concentrate, topicals, prerolls, etc?
         string Type { get; set; }
    }
}