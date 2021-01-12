using System;
using System.Collections.Generic;
using StoreDataBase.Repositories;
using StoreDataBase.Models;


namespace StoreBusinessLogic
{
    public class ProductValidation
    {
        ProductRepo repo = new ProductRepo();

        public List<Product> CheckProducts()
        {
            var products = repo.GetAllProducts();
            if(products == null)
            {
                throw new NullReferenceException("There ain't shit here, wtf");
            }
            else
            {
                return products;
            }
        }
    }
}
