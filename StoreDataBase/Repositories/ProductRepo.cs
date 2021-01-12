using System;
using System.Collections.Generic;
using StoreDataBase.Models;
namespace StoreDataBase.Repositories
{
    public class ProductRepo
    {
        public List<Product> GetAllProducts()
        {
            List<Product> product = new List<Product>(){
                new Product(){Id=1, Name="Blue Dream", Created=new System.DateTime(12/01/2021), Price=5.00M},
                new Product(){Id=2, Name="Citrus Sap", Created=new System.DateTime(12/01/2021), Price=5.00M}
            };
            return product;
        }
    }
}