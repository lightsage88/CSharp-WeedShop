using System;
using StoreBusinessLogic;
namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int input = 0;
            System.Console.WriteLine("Welcome to the Weed Shop");
            input = Int32.Parse(Console.ReadLine());
            switch(input)
            {
                case 1: 
                    GetProducts();
                    break;
                default:
                    GetProducts();
                    break;
            }
            Console.ReadLine();
        }

        public static void GetProducts()
        {
            ProductValidation productValidation = new ProductValidation();
            var products = productValidation.CheckProducts();
            foreach (var product in products)
            {
                System.Console.WriteLine(product.Name);
            }
        }
    }
}
